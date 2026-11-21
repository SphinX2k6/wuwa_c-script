using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A35 RID: 6709
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhonographMusicPlayItem : GridProxyAbstract<IPhonographMusicItemData>
{
	// Token: 0x06010874 RID: 67700 RVA: 0x004D68B0 File Offset: 0x004D4AB0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x06010875 RID: 67701 RVA: 0x004D699B File Offset: 0x004D4B9B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010876 RID: 67702 RVA: 0x004D69B0 File Offset: 0x004D4BB0
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPhonographPlayStop, new Action(this.OnPlayStop));
		EventSystem.Instance.Add(EEventName.OnPhonographSelectDisable, new Action<int>(this.OnSelectDisable));
		base.GetExtendToggle(0).bCanClickWhenDisable = true;
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickUndetermined));
		EventSystem.Instance.Add(EEventName.OnPhonographSetBgm, new Action<int>(this.OnSetBgm));
	}

	// Token: 0x06010877 RID: 67703 RVA: 0x004D6A3B File Offset: 0x004D4C3B
	public void OnTick()
	{
		if (this.MusicId != PhonographModel.Instance.CurrentPlayMusicId)
		{
			return;
		}
		this.RefreshTime();
	}

	// Token: 0x06010878 RID: 67704 RVA: 0x004D6A58 File Offset: 0x004D4C58
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPhonographPlayStop, new Action(this.OnPlayStop));
		EventSystem.Instance.Remove(EEventName.OnPhonographSelectDisable, new Action<int>(this.OnSelectDisable));
		EventSystem.Instance.Remove(EEventName.OnPhonographSetBgm, new Action<int>(this.OnSetBgm));
	}

	// Token: 0x06010879 RID: 67705 RVA: 0x004D6AB9 File Offset: 0x004D4CB9
	private void OnSetBgm(int musicId)
	{
		base.GetItem(7).SetUIActive(musicId == this.MusicId);
	}

	// Token: 0x0601087A RID: 67706 RVA: 0x004D6AD0 File Offset: 0x004D4CD0
	private void OnSelectDisable(int musicId)
	{
		if (this.MusicId == musicId)
		{
			return;
		}
		base.GetSprite(6).SetAlpha(0f);
	}

	// Token: 0x0601087B RID: 67707 RVA: 0x004D6AF0 File Offset: 0x004D4CF0
	private void OnClickUndetermined()
	{
		Action<int, int> onClickMusicItem = this.OnClickMusicItem;
		if (onClickMusicItem != null)
		{
			onClickMusicItem(this.MusicId, base.GridIndex);
		}
		base.GetSprite(6).SetAlpha(1f);
		EventSystem.Instance.Emit<int>(EEventName.OnPhonographSelectDisable, this.MusicId);
	}

	// Token: 0x0601087C RID: 67708 RVA: 0x004D6B44 File Offset: 0x004D4D44
	private void OnClick(EToggleState state)
	{
		PhonographModel instance = PhonographModel.Instance;
		int? num = (instance != null) ? new int?(instance.CurrentPlayMusicId) : null;
		int musicId = this.MusicId;
		if (num.GetValueOrDefault() == musicId & num != null)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		Action<int, int> onClickMusicItem = this.OnClickMusicItem;
		if (onClickMusicItem != null)
		{
			onClickMusicItem(this.MusicId, base.GridIndex);
		}
		if (!PhonographModel.Instance.IsUnlockMusic(this.MusicId))
		{
			return;
		}
		this.RefreshTime();
		base.GetItem(4).SetUIActive(false);
		this.LevelSequencePlayer.PlaySequencePurely("Play", false, false, null, null, false);
	}

	// Token: 0x0601087D RID: 67709 RVA: 0x004D6BFC File Offset: 0x004D4DFC
	public void OnPlayStop()
	{
		if (this.MusicId != PhonographModel.Instance.CurrentPlayMusicId)
		{
			return;
		}
		base.GetText(3).SetText(TimeUtil.Instance.GetTimeString((double)this.TotalTime), true);
		base.GetSprite(2).SetFillAmount(0f);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlaySequencePurely("Stop", false, false, null, null, false);
	}

	// Token: 0x0601087E RID: 67710 RVA: 0x004D6C80 File Offset: 0x004D4E80
	public void RefreshTime()
	{
		int currentPlayTimeFromAudio = PhonographModel.Instance.GetCurrentPlayTimeFromAudio();
		base.GetText(3).SetText(TimeUtil.Instance.GetTimeString((double)currentPlayTimeFromAudio) + "/" + TimeUtil.Instance.GetTimeString((double)this.TotalTime), true);
		base.GetSprite(2).SetFillAmount((float)currentPlayTimeFromAudio / (float)this.TotalTime);
	}

	// Token: 0x0601087F RID: 67711 RVA: 0x004D6CE4 File Offset: 0x004D4EE4
	[NullableContext(1)]
	public override void Refresh(IPhonographMusicItemData data, bool isSelected, int gridIndex)
	{
		this.MusicId = data.Id;
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(data.Id) : null;
		if (phonographMusic == null)
		{
			return;
		}
		base.GetItem(7).SetUIActive(PhonographModel.Instance.RecordMusicId == data.Id);
		this.TotalTime = (int)Math.Floor((double)data.Duration);
		bool flag = PhonographModel.Instance.CurrentPlayMusicId == data.Id;
		if (flag)
		{
			this.RefreshTime();
		}
		else
		{
			base.GetSprite(2).SetFillAmount(0f);
			base.GetText(3).SetText(TimeUtil.Instance.GetTimeString((double)this.TotalTime), true);
		}
		if (PhonographModel.Instance.IsUnlockMusic(data.Id))
		{
			this.LevelSequencePlayer.PlaySequencePurely("Unlock", false, false, null, null, false);
		}
		else
		{
			this.LevelSequencePlayer.PlaySequencePurely("Lock", false, false, null, null, false);
		}
		if (flag)
		{
			this.LevelSequencePlayer.PlaySequencePurely("Play", false, false, null, null, false);
		}
		else
		{
			this.LevelSequencePlayer.PlaySequencePurely("Stop", false, false, null, null, false);
		}
		EToggleState state = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetSprite(6).SetAlpha(isSelected > false);
		base.GetExtendToggle(0).CanExecuteChange.Unbind();
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		base.GetExtendToggle(0).CanExecuteChange.Bind(delegate()
		{
			PhonographModel instance2 = PhonographModel.Instance;
			int? num = (instance2 != null) ? new int?(instance2.CurrentPlayMusicId) : null;
			int musicId = this.MusicId;
			if (num.GetValueOrDefault() == musicId & num != null)
			{
				PhonographModel instance3 = PhonographModel.Instance;
				num = ((instance3 != null) ? new int?(instance3.CurrentSelectMusicId) : null);
				musicId = this.MusicId;
				if (!(num.GetValueOrDefault() == musicId & num != null))
				{
					return true;
				}
			}
			PhonographModel instance4 = PhonographModel.Instance;
			num = ((instance4 != null) ? new int?(instance4.CurrentPlayMusicId) : null);
			musicId = this.MusicId;
			if (!(num.GetValueOrDefault() == musicId & num != null))
			{
				PhonographModel instance5 = PhonographModel.Instance;
				num = ((instance5 != null) ? new int?(instance5.CurrentSelectMusicId) : null);
				musicId = this.MusicId;
				if (num.GetValueOrDefault() == musicId & num != null)
				{
					this.OnClick(EToggleState.ETT_UnChecked);
					return false;
				}
			}
			return PhonographModel.Instance.CurrentSelectMusicId != this.MusicId;
		});
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phonographMusic.Value.Title, Array.Empty<object>());
		base.GetItem(4).SetUIActive(PhonographModel.Instance.IsNewMusic(data.Id));
	}

	// Token: 0x06010880 RID: 67712 RVA: 0x004D6ECA File Offset: 0x004D50CA
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06010881 RID: 67713 RVA: 0x004D6EDD File Offset: 0x004D50DD
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06010882 RID: 67714 RVA: 0x004D6EF0 File Offset: 0x004D50F0
	protected override void OnBeforeDestroy()
	{
		if (this.UpdateTimeHandle != null)
		{
			TimerSystem.Instance.Remove(this.UpdateTimeHandle);
			this.UpdateTimeHandle = null;
		}
	}

	// Token: 0x04009289 RID: 37513
	public Action<int, int> OnClickMusicItem;

	// Token: 0x0400928A RID: 37514
	protected int MusicId;

	// Token: 0x0400928B RID: 37515
	protected int TotalTime;

	// Token: 0x0400928C RID: 37516
	protected int CurrentTime;

	// Token: 0x0400928D RID: 37517
	protected TimerHandle UpdateTimeHandle;

	// Token: 0x0400928E RID: 37518
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007C8C RID: 31884
	[NullableContext(0)]
	private static class EPhonographMusicPlayItemDefine
	{
		// Token: 0x04028554 RID: 165204
		public const int ExtendToggle = 0;

		// Token: 0x04028555 RID: 165205
		public const int TxtName = 1;

		// Token: 0x04028556 RID: 165206
		public const int SpriteProgress = 2;

		// Token: 0x04028557 RID: 165207
		public const int TxtTime = 3;

		// Token: 0x04028558 RID: 165208
		public const int NewItem = 4;

		// Token: 0x04028559 RID: 165209
		public const int LockItem = 5;

		// Token: 0x0402855A RID: 165210
		public const int SelectItem = 6;

		// Token: 0x0402855B RID: 165211
		public const int BgmTagItem = 7;
	}
}
