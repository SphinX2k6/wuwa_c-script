using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017AC RID: 6060
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleMusicItemGrid : GridProxyAbstract<IMusicUiData>
{
	// Token: 0x0600EC59 RID: 60505 RVA: 0x004568A8 File Offset: 0x00454AA8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendToggleTogDiscList)),
			new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnExtendToggleTogLike))
		};
	}

	// Token: 0x0600EC5A RID: 60506 RVA: 0x004569D8 File Offset: 0x00454BD8
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600EC5B RID: 60507 RVA: 0x004569EA File Offset: 0x00454BEA
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EC5C RID: 60508 RVA: 0x004569FC File Offset: 0x00454BFC
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnTogLockClick));
	}

	// Token: 0x0600EC5D RID: 60509 RVA: 0x00456A1B File Offset: 0x00454C1B
	private void OnTogLockClick()
	{
		if (this.Id == -1)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.MotorcycleMusicDetailView, this.Id, null);
	}

	// Token: 0x0600EC5E RID: 60510 RVA: 0x00456A42 File Offset: 0x00454C42
	private void OnExtendToggleTogDiscList(EToggleState toggleState)
	{
		if (this.Id == -1)
		{
			return;
		}
		if (MotorcycleMusicPlayerModel.Instance.IsMusicUnlock(this.Id))
		{
			Action<int> onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback(this.Id);
		}
	}

	// Token: 0x0600EC5F RID: 60511 RVA: 0x00456A78 File Offset: 0x00454C78
	private void OnExtendToggleTogLike(EToggleState toggleState)
	{
		if (this.Id == -1)
		{
			return;
		}
		if (!MotorcycleMusicPlayerModel.Instance.IsMusicUnlock(this.Id))
		{
			this.RefreshLikeToggle();
			UiManager.Instance.OpenView(EUiViewName.MotorcycleMusicDetailView, this.Id, null);
			return;
		}
		Action<int> onClickLikeCallback = this.OnClickLikeCallback;
		if (onClickLikeCallback == null)
		{
			return;
		}
		onClickLikeCallback(this.Id);
	}

	// Token: 0x0600EC60 RID: 60512 RVA: 0x00456AD9 File Offset: 0x00454CD9
	private void RefreshLikeToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(this.Id) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, true, false);
	}

	// Token: 0x0600EC61 RID: 60513 RVA: 0x00456B08 File Offset: 0x00454D08
	[NullableContext(1)]
	public override void Refresh(IMusicUiData data, bool isSelected, int gridIndex)
	{
		this.Id = data.Id;
		int id = data.Id;
		PhonographConfig instance = PhonographConfig.Instance;
		PhonographMusic? phonographMusic = (instance != null) ? instance.GetMusicById(id) : null;
		if (phonographMusic == null)
		{
			return;
		}
		this.Id = id;
		bool flag = MotorcycleMusicPlayerModel.Instance.IsMusicUnlock(id);
		bool flag2 = flag && MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId() == id;
		bool isPause = MotorcycleMusicPlayerModel.Instance.GetIsPause();
		this.RefreshLikeToggle();
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(MotorcycleMusicPlayerModel.Instance.IsMusicNew(this.Id));
		}
		base.GetExtendToggle(0).SetToggleStateForce((MotorcycleMusicPlayerModel.Instance.GetCurPlayMusicId() == this.Id) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, true);
		if (!flag)
		{
			base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
		}
		UUISprite sprite = base.GetSprite(7);
		if (sprite != null)
		{
			sprite.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(flag2 && !isPause);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(flag && !flag2);
		}
		UUIItem item4 = base.GetItem(8);
		if (item4 != null)
		{
			item4.SetUIActive(flag2 && isPause);
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(phonographMusic.Value.Title);
		}
		bool uiactive = MotorcycleMusicPlayerModel.Instance.IsTimeLimitMusic(this.Id);
		UUIItem item5 = base.GetItem(9);
		if (item5 != null)
		{
			item5.SetUIActive(uiactive);
		}
		UUIItem uuiitem = base.GetExtendToggle(3).RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(flag);
		}
		this.RefreshMusicDurationAsync(this.Id);
	}

	// Token: 0x0600EC62 RID: 60514 RVA: 0x00456CC0 File Offset: 0x00454EC0
	private UniTask RefreshMusicDurationAsync(int musicId)
	{
		MotorcycleMusicItemGrid.<RefreshMusicDurationAsync>d__13 <RefreshMusicDurationAsync>d__;
		<RefreshMusicDurationAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMusicDurationAsync>d__.<>4__this = this;
		<RefreshMusicDurationAsync>d__.musicId = musicId;
		<RefreshMusicDurationAsync>d__.<>1__state = -1;
		<RefreshMusicDurationAsync>d__.<>t__builder.Start<MotorcycleMusicItemGrid.<RefreshMusicDurationAsync>d__13>(ref <RefreshMusicDurationAsync>d__);
		return <RefreshMusicDurationAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04008607 RID: 34311
	public Action<int> OnClickCallback;

	// Token: 0x04008608 RID: 34312
	public Action<int> OnClickLikeCallback;

	// Token: 0x04008609 RID: 34313
	private int Id = -1;

	// Token: 0x020079C6 RID: 31174
	[NullableContext(0)]
	private class EMusicComponents
	{
		// Token: 0x04027763 RID: 161635
		public const int Tog = 0;

		// Token: 0x04027764 RID: 161636
		public const int TxtListName = 1;

		// Token: 0x04027765 RID: 161637
		public const int TxtListName1 = 2;

		// Token: 0x04027766 RID: 161638
		public const int TogLike = 3;

		// Token: 0x04027767 RID: 161639
		public const int UiItemTagNew = 4;

		// Token: 0x04027768 RID: 161640
		public const int SpriteStatePlay = 5;

		// Token: 0x04027769 RID: 161641
		public const int SpriteStatePlaying = 6;

		// Token: 0x0402776A RID: 161642
		public const int SpriteLock = 7;

		// Token: 0x0402776B RID: 161643
		public const int PanelPause = 8;

		// Token: 0x0402776C RID: 161644
		public const int SprTimeLimit = 9;
	}
}
