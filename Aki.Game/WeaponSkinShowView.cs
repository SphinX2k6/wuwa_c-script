using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A65 RID: 10853
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinShowView : UiTickViewBase
{
	// Token: 0x060169EF RID: 92655 RVA: 0x005BBCB2 File Offset: 0x005B9EB2
	public WeaponSkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060169F0 RID: 92656 RVA: 0x005BBCD4 File Offset: 0x005B9ED4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnClickHideToggle))
		};
	}

	// Token: 0x060169F1 RID: 92657 RVA: 0x005BBDAC File Offset: 0x005B9FAC
	protected override void OnStart()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseView));
		this.CaptionItem.SetHelpBtnActive(false);
		this.CaptionItem.SetTitleLocalText("WeaponSkin_Preview");
		WeaponSkinShowViewData weaponSkinShowViewData = this.OpenParam as WeaponSkinShowViewData;
		List<int> list = ((weaponSkinShowViewData != null) ? weaponSkinShowViewData.SkinIdList : null) ?? new List<int>();
		this.SkinDataList = new List<WeaponSkinData>();
		foreach (int skinId in list)
		{
			WeaponSkinModel instance = WeaponSkinModel.Instance;
			int valueOrDefault = ((instance != null) ? instance.GetRoleIdBySkinId(skinId) : null).GetValueOrDefault();
			this.SkinDataList.Add(new WeaponSkinData(skinId, valueOrDefault));
		}
		this.SkinScrollView = new LoopScrollView<WeaponSkinPreviewGridItem, WeaponSkinData>(base.GetLoopScrollViewComponent(5), base.GetItem(6).GetOwner() as AUIBaseActor, new Func<WeaponSkinPreviewGridItem>(this.CreateSkinGridItem), false);
	}

	// Token: 0x060169F2 RID: 92658 RVA: 0x005BBED4 File Offset: 0x005BA0D4
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		WeaponSkinShowView.<OnHandlePostLoadSceneAsync>d__11 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<WeaponSkinShowView.<OnHandlePostLoadSceneAsync>d__11>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060169F3 RID: 92659 RVA: 0x005BBF18 File Offset: 0x005BA118
	protected override void OnBeforeDestroy()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
		if (this.WeaponObserver != null)
		{
			UiSceneManager.Instance.DestroyWeaponObserver(this.WeaponObserver);
			this.WeaponObserver = null;
		}
		if (this.WeaponScabbardObserver != null)
		{
			UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.WeaponScabbardObserver);
			this.WeaponScabbardObserver = null;
		}
	}

	// Token: 0x060169F4 RID: 92660 RVA: 0x005BBF6E File Offset: 0x005BA16E
	private WeaponSkinPreviewGridItem CreateSkinGridItem()
	{
		WeaponSkinPreviewGridItem weaponSkinPreviewGridItem = new WeaponSkinPreviewGridItem();
		weaponSkinPreviewGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickSkinGridItem));
		return weaponSkinPreviewGridItem;
	}

	// Token: 0x060169F5 RID: 92661 RVA: 0x005BBF88 File Offset: 0x005BA188
	private void OnClickSkinGridItem(MediumItemGridExtendCallback parameters)
	{
		WeaponSkinData weaponSkinData = parameters.Data as WeaponSkinData;
		if (weaponSkinData == null)
		{
			return;
		}
		this.SwitchSkin(weaponSkinData.SkinId);
	}

	// Token: 0x060169F6 RID: 92662 RVA: 0x005BBFB1 File Offset: 0x005BA1B1
	private void SelectSkinByIndex(int index)
	{
		LoopScrollView<WeaponSkinPreviewGridItem, WeaponSkinData> skinScrollView = this.SkinScrollView;
		if (skinScrollView != null)
		{
			skinScrollView.DeselectCurrentGridProxy(false);
		}
		LoopScrollView<WeaponSkinPreviewGridItem, WeaponSkinData> skinScrollView2 = this.SkinScrollView;
		if (skinScrollView2 != null)
		{
			skinScrollView2.SelectGridProxy(index, true);
		}
		this.SwitchSkin(this.SkinDataList[index].SkinId);
	}

	// Token: 0x060169F7 RID: 92663 RVA: 0x005BBFEF File Offset: 0x005BA1EF
	private void SwitchSkin(int skinId)
	{
		if (this.CurrentSkinId == skinId)
		{
			return;
		}
		this.CurrentSkinId = skinId;
		this.LoadWeaponModel(skinId);
		this.RefreshText(skinId);
	}

	// Token: 0x060169F8 RID: 92664 RVA: 0x005BC010 File Offset: 0x005BA210
	private void LoadWeaponModel(int skinId)
	{
		if (this.WeaponObserver == null || this.WeaponScabbardObserver == null)
		{
			return;
		}
		WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(skinId);
		this.TrialWeaponData.SetTrialId(weaponSkinConfig.HandBookTrialId, true);
		WeaponController.Instance.OnSelectedWeaponChange(this.TrialWeaponData, this.WeaponObserver, this.WeaponScabbardObserver, skinId, false);
	}

	// Token: 0x060169F9 RID: 92665 RVA: 0x005BC06C File Offset: 0x005BA26C
	private void RefreshText(int skinId)
	{
		WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(skinId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), weaponSkinConfig.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), weaponSkinConfig.BgDescription, Array.Empty<object>());
	}

	// Token: 0x060169FA RID: 92666 RVA: 0x005BC0BF File Offset: 0x005BA2BF
	private void OnClickHideToggle(EToggleState toggleState)
	{
		UUIItem item = base.GetItem(1);
		item.SetUIActive(!item.bIsUIActive);
	}

	// Token: 0x060169FB RID: 92667 RVA: 0x005BC0D6 File Offset: 0x005BA2D6
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400A7BD RID: 42941
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A7BE RID: 42942
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<WeaponSkinPreviewGridItem, WeaponSkinData> SkinScrollView;

	// Token: 0x0400A7BF RID: 42943
	private List<WeaponSkinData> SkinDataList = new List<WeaponSkinData>();

	// Token: 0x0400A7C0 RID: 42944
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400A7C1 RID: 42945
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400A7C2 RID: 42946
	private readonly WeaponTrialData TrialWeaponData = new WeaponTrialData();

	// Token: 0x0400A7C3 RID: 42947
	private int CurrentSkinId;

	// Token: 0x020090A3 RID: 37027
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402EDDC RID: 191964
		CaptionItem,
		// Token: 0x0402EDDD RID: 191965
		HideRootItem,
		// Token: 0x0402EDDE RID: 191966
		TitleText,
		// Token: 0x0402EDDF RID: 191967
		DescText,
		// Token: 0x0402EDE0 RID: 191968
		HideToggle,
		// Token: 0x0402EDE1 RID: 191969
		LoopScrollView,
		// Token: 0x0402EDE2 RID: 191970
		WeaponSkinItem
	}
}
