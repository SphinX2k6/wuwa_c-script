using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022C8 RID: 8904
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleMusicItemGrid : GridProxyAbstract<IMusicUiData>
{
	// Token: 0x060117C2 RID: 71618 RVA: 0x00449B80 File Offset: 0x00447D80
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

	// Token: 0x060117C3 RID: 71619 RVA: 0x00449CB0 File Offset: 0x00447EB0
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060117C4 RID: 71620 RVA: 0x00449CC2 File Offset: 0x00447EC2
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060117C5 RID: 71621 RVA: 0x00449CD4 File Offset: 0x00447ED4
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnTogLockClick));
	}

	// Token: 0x060117C6 RID: 71622 RVA: 0x00449CF3 File Offset: 0x00447EF3
	private void OnTogLockClick()
	{
		if (this.Id == -1)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.MotorcycleMusicDetailView, this.Id, null);
	}

	// Token: 0x060117C7 RID: 71623 RVA: 0x00449D1A File Offset: 0x00447F1A
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

	// Token: 0x060117C8 RID: 71624 RVA: 0x00449D50 File Offset: 0x00447F50
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

	// Token: 0x060117C9 RID: 71625 RVA: 0x00449DB1 File Offset: 0x00447FB1
	private void RefreshLikeToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(MotorcycleMusicPlayerModel.Instance.IsMusicFavorite(this.Id) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, true, false);
	}

	// Token: 0x060117CA RID: 71626 RVA: 0x00449DE0 File Offset: 0x00447FE0
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

	// Token: 0x060117CB RID: 71627 RVA: 0x00449F98 File Offset: 0x00448198
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

	// Token: 0x040084C9 RID: 33993
	public Action<int> OnClickCallback;

	// Token: 0x040084CA RID: 33994
	public Action<int> OnClickLikeCallback;

	// Token: 0x040084CB RID: 33995
	private int Id = -1;

	// Token: 0x02008842 RID: 34882
	[NullableContext(0)]
	private class EMusicComponents
	{
		// Token: 0x0402C461 RID: 181345
		public const int Tog = 0;

		// Token: 0x0402C462 RID: 181346
		public const int TxtListName = 1;

		// Token: 0x0402C463 RID: 181347
		public const int TxtListName1 = 2;

		// Token: 0x0402C464 RID: 181348
		public const int TogLike = 3;

		// Token: 0x0402C465 RID: 181349
		public const int UiItemTagNew = 4;

		// Token: 0x0402C466 RID: 181350
		public const int SpriteStatePlay = 5;

		// Token: 0x0402C467 RID: 181351
		public const int SpriteStatePlaying = 6;

		// Token: 0x0402C468 RID: 181352
		public const int SpriteLock = 7;

		// Token: 0x0402C469 RID: 181353
		public const int PanelPause = 8;

		// Token: 0x0402C46A RID: 181354
		public const int SprTimeLimit = 9;
	}
}
