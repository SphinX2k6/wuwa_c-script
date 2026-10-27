using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200254A RID: 9546
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhonographMusicPlayItem : GridProxyAbstract<IPhonographMusicItemData>
{
	// Token: 0x06013394 RID: 78740 RVA: 0x004C7D34 File Offset: 0x004C5F34
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

	// Token: 0x06013395 RID: 78741 RVA: 0x004C7E1F File Offset: 0x004C601F
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013396 RID: 78742 RVA: 0x004C7E34 File Offset: 0x004C6034
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPhonographPlayStop, new Action(this.OnPlayStop));
		EventSystem.Instance.Add(EEventName.OnPhonographSelectDisable, new Action<int>(this.OnSelectDisable));
		base.GetExtendToggle(0).bCanClickWhenDisable = true;
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickUndetermined));
		EventSystem.Instance.Add(EEventName.OnPhonographSetBgm, new Action<int>(this.OnSetBgm));
	}

	// Token: 0x06013397 RID: 78743 RVA: 0x004C7EBF File Offset: 0x004C60BF
	public void OnTick()
	{
		if (this.MusicId != PhonographModel.Instance.CurrentPlayMusicId)
		{
			return;
		}
		this.RefreshTime();
	}

	// Token: 0x06013398 RID: 78744 RVA: 0x004C7EDC File Offset: 0x004C60DC
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPhonographPlayStop, new Action(this.OnPlayStop));
		EventSystem.Instance.Remove(EEventName.OnPhonographSelectDisable, new Action<int>(this.OnSelectDisable));
		EventSystem.Instance.Remove(EEventName.OnPhonographSetBgm, new Action<int>(this.OnSetBgm));
	}

	// Token: 0x06013399 RID: 78745 RVA: 0x004C7F3D File Offset: 0x004C613D
	private void OnSetBgm(int musicId)
	{
		base.GetItem(7).SetUIActive(musicId == this.MusicId);
	}

	// Token: 0x0601339A RID: 78746 RVA: 0x004C7F54 File Offset: 0x004C6154
	private void OnSelectDisable(int musicId)
	{
		if (this.MusicId == musicId)
		{
			return;
		}
		base.GetSprite(6).SetAlpha(0f);
	}

	// Token: 0x0601339B RID: 78747 RVA: 0x004C7F74 File Offset: 0x004C6174
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

	// Token: 0x0601339C RID: 78748 RVA: 0x004C7FC8 File Offset: 0x004C61C8
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

	// Token: 0x0601339D RID: 78749 RVA: 0x004C8080 File Offset: 0x004C6280
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

	// Token: 0x0601339E RID: 78750 RVA: 0x004C8104 File Offset: 0x004C6304
	public void RefreshTime()
	{
		int currentPlayTimeFromAudio = PhonographModel.Instance.GetCurrentPlayTimeFromAudio();
		base.GetText(3).SetText(TimeUtil.Instance.GetTimeString((double)currentPlayTimeFromAudio) + "/" + TimeUtil.Instance.GetTimeString((double)this.TotalTime), true);
		base.GetSprite(2).SetFillAmount((float)currentPlayTimeFromAudio / (float)this.TotalTime);
	}

	// Token: 0x0601339F RID: 78751 RVA: 0x004C8168 File Offset: 0x004C6368
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

	// Token: 0x060133A0 RID: 78752 RVA: 0x004C834E File Offset: 0x004C654E
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060133A1 RID: 78753 RVA: 0x004C8361 File Offset: 0x004C6561
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060133A2 RID: 78754 RVA: 0x004C8374 File Offset: 0x004C6574
	protected override void OnBeforeDestroy()
	{
		if (this.UpdateTimeHandle != null)
		{
			TimerSystem.Instance.Remove(this.UpdateTimeHandle);
			this.UpdateTimeHandle = null;
		}
	}

	// Token: 0x04009130 RID: 37168
	public Action<int, int> OnClickMusicItem;

	// Token: 0x04009131 RID: 37169
	protected int MusicId;

	// Token: 0x04009132 RID: 37170
	protected int TotalTime;

	// Token: 0x04009133 RID: 37171
	protected int CurrentTime;

	// Token: 0x04009134 RID: 37172
	protected TimerHandle UpdateTimeHandle;

	// Token: 0x04009135 RID: 37173
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008B06 RID: 35590
	[NullableContext(0)]
	private static class EPhonographMusicPlayItemDefine
	{
		// Token: 0x0402D245 RID: 184901
		public const int ExtendToggle = 0;

		// Token: 0x0402D246 RID: 184902
		public const int TxtName = 1;

		// Token: 0x0402D247 RID: 184903
		public const int SpriteProgress = 2;

		// Token: 0x0402D248 RID: 184904
		public const int TxtTime = 3;

		// Token: 0x0402D249 RID: 184905
		public const int NewItem = 4;

		// Token: 0x0402D24A RID: 184906
		public const int LockItem = 5;

		// Token: 0x0402D24B RID: 184907
		public const int SelectItem = 6;

		// Token: 0x0402D24C RID: 184908
		public const int BgmTagItem = 7;
	}
}
