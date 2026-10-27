using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002547 RID: 9543
public class PhonographAlbumItem : GridProxyAbstract<int>
{
	// Token: 0x06013382 RID: 78722 RVA: 0x004C78C4 File Offset: 0x004C5AC4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick))
		};
	}

	// Token: 0x06013383 RID: 78723 RVA: 0x004C796D File Offset: 0x004C5B6D
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013384 RID: 78724 RVA: 0x004C7980 File Offset: 0x004C5B80
	private void OnClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int, int> onClickAlbumItem = this.OnClickAlbumItem;
			if (onClickAlbumItem == null)
			{
				return;
			}
			onClickAlbumItem(this.AlbumId, base.GridIndex);
		}
	}

	// Token: 0x06013385 RID: 78725 RVA: 0x004C79A2 File Offset: 0x004C5BA2
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPhonographRemoveNewTag, new Action(this.OnRemoveNewTag));
		EventSystem.Instance.Add(EEventName.OnPhonographSwitchMusic, new Action(this.OnSwitchMusic));
	}

	// Token: 0x06013386 RID: 78726 RVA: 0x004C79DC File Offset: 0x004C5BDC
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPhonographRemoveNewTag, new Action(this.OnRemoveNewTag));
		EventSystem.Instance.Remove(EEventName.OnPhonographSwitchMusic, new Action(this.OnSwitchMusic));
	}

	// Token: 0x06013387 RID: 78727 RVA: 0x004C7A18 File Offset: 0x004C5C18
	private void OnSwitchMusic()
	{
		PhonographModel instance = PhonographModel.Instance;
		if (instance != null && instance.CurrentPlayMusicId == 0 && this.IsPlayMusic)
		{
			this.IsPlayMusic = false;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Stop", false, false, null, null, false);
			return;
		}
		else
		{
			PhonographModel instance2 = PhonographModel.Instance;
			int? num = (instance2 != null) ? new int?(instance2.CurrentPlayMusicId) : null;
			int? num2 = num;
			int num3 = 0;
			if (num2.GetValueOrDefault() == num3 & num2 != null)
			{
				return;
			}
			PhonographConfig instance3 = PhonographConfig.Instance;
			PhonographMusic? phonographMusic = (instance3 != null) ? instance3.GetMusicById(num.Value) : null;
			if (phonographMusic == null)
			{
				return;
			}
			bool flag = false;
			PhonographMusic value = phonographMusic.Value;
			for (int i = 0; i < value.AlbumLength; i++)
			{
				if (value.Album(i) == this.AlbumId)
				{
					flag = true;
					break;
				}
			}
			if (!flag || this.IsPlayMusic)
			{
				if (!flag && this.IsPlayMusic)
				{
					this.IsPlayMusic = false;
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlaySequencePurely("Stop", false, false, null, null, false);
				}
				return;
			}
			this.IsPlayMusic = true;
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 == null)
			{
				return;
			}
			levelSequencePlayer3.PlaySequencePurely("Play", false, false, null, null, false);
			return;
		}
	}

	// Token: 0x06013388 RID: 78728 RVA: 0x004C7B78 File Offset: 0x004C5D78
	private void OnRemoveNewTag()
	{
		bool uiactive = PhonographModel.Instance.CheckAlbumHasNewMusic(this.AlbumId);
		base.GetItem(2).SetUIActive(uiactive);
	}

	// Token: 0x06013389 RID: 78729 RVA: 0x004C7BA4 File Offset: 0x004C5DA4
	public override void Refresh(int albumId, bool isSelected, int gridIndex)
	{
		this.AlbumId = albumId;
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographAlbum? phonographAlbum = (instance != null) ? instance.GetMusicAlbumById(albumId) : null;
		if (phonographAlbum == null)
		{
			return;
		}
		base.GetExtendToggle(0).SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		bool uiactive = PhonographModel.Instance.CheckAlbumHasNewMusic(albumId);
		base.GetItem(2).SetUIActive(uiactive);
		this.SetSpriteByPath(phonographAlbum.Value.Icon, base.GetSprite(1), false, null, null);
		MotorcycleMusicPlayerModel instance2 = MotorcycleMusicPlayerModel.Instance;
		bool flag = instance2 != null && instance2.IsTimeLimitAlbum(albumId);
		base.GetItem(3).SetUIActive(flag);
		if (flag)
		{
			MotorcycleMusicPlayerModel instance3 = MotorcycleMusicPlayerModel.Instance;
			string newText = ((instance3 != null) ? instance3.GetAlbumTimeLimitRemainText(albumId) : null) ?? "";
			base.GetText(4).SetText(newText, true);
		}
	}

	// Token: 0x0601338A RID: 78730 RVA: 0x004C7C84 File Offset: 0x004C5E84
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			Action<int, int> onClickAlbumItem = this.OnClickAlbumItem;
			if (onClickAlbumItem != null)
			{
				onClickAlbumItem(this.AlbumId, base.GridIndex);
			}
		}
		if (this.IsPlayMusic)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlaySequencePurely("Play", false, false, null, null, false);
		}
	}

	// Token: 0x0601338B RID: 78731 RVA: 0x004C7CEC File Offset: 0x004C5EEC
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400912A RID: 37162
	[Nullable(2)]
	public Action<int, int> OnClickAlbumItem;

	// Token: 0x0400912B RID: 37163
	protected int AlbumId;

	// Token: 0x0400912C RID: 37164
	protected bool IsPlayMusic;

	// Token: 0x0400912D RID: 37165
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02008B05 RID: 35589
	private static class EPhonographAlbumItemDefine
	{
		// Token: 0x0402D240 RID: 184896
		public const int ExtendToggle = 0;

		// Token: 0x0402D241 RID: 184897
		public const int SpriteIcon = 1;

		// Token: 0x0402D242 RID: 184898
		public const int NewItem = 2;

		// Token: 0x0402D243 RID: 184899
		public const int PnlTimeLimit = 3;

		// Token: 0x0402D244 RID: 184900
		public const int TxtTimeLimit = 4;
	}
}
