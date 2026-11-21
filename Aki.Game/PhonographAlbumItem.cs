using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A32 RID: 6706
public class PhonographAlbumItem : GridProxyAbstract<int>
{
	// Token: 0x06010862 RID: 67682 RVA: 0x004D6440 File Offset: 0x004D4640
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

	// Token: 0x06010863 RID: 67683 RVA: 0x004D64E9 File Offset: 0x004D46E9
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06010864 RID: 67684 RVA: 0x004D64FC File Offset: 0x004D46FC
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

	// Token: 0x06010865 RID: 67685 RVA: 0x004D651E File Offset: 0x004D471E
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.OnPhonographRemoveNewTag, new Action(this.OnRemoveNewTag));
		EventSystem.Instance.Add(EEventName.OnPhonographSwitchMusic, new Action(this.OnSwitchMusic));
	}

	// Token: 0x06010866 RID: 67686 RVA: 0x004D6558 File Offset: 0x004D4758
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.OnPhonographRemoveNewTag, new Action(this.OnRemoveNewTag));
		EventSystem.Instance.Remove(EEventName.OnPhonographSwitchMusic, new Action(this.OnSwitchMusic));
	}

	// Token: 0x06010867 RID: 67687 RVA: 0x004D6594 File Offset: 0x004D4794
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

	// Token: 0x06010868 RID: 67688 RVA: 0x004D66F4 File Offset: 0x004D48F4
	private void OnRemoveNewTag()
	{
		bool uiactive = PhonographModel.Instance.CheckAlbumHasNewMusic(this.AlbumId);
		base.GetItem(2).SetUIActive(uiactive);
	}

	// Token: 0x06010869 RID: 67689 RVA: 0x004D6720 File Offset: 0x004D4920
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

	// Token: 0x0601086A RID: 67690 RVA: 0x004D6800 File Offset: 0x004D4A00
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

	// Token: 0x0601086B RID: 67691 RVA: 0x004D6868 File Offset: 0x004D4A68
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04009283 RID: 37507
	[Nullable(2)]
	public Action<int, int> OnClickAlbumItem;

	// Token: 0x04009284 RID: 37508
	protected int AlbumId;

	// Token: 0x04009285 RID: 37509
	protected bool IsPlayMusic;

	// Token: 0x04009286 RID: 37510
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x02007C8B RID: 31883
	private static class EPhonographAlbumItemDefine
	{
		// Token: 0x0402854F RID: 165199
		public const int ExtendToggle = 0;

		// Token: 0x04028550 RID: 165200
		public const int SpriteIcon = 1;

		// Token: 0x04028551 RID: 165201
		public const int NewItem = 2;

		// Token: 0x04028552 RID: 165202
		public const int PnlTimeLimit = 3;

		// Token: 0x04028553 RID: 165203
		public const int TxtTimeLimit = 4;
	}
}
