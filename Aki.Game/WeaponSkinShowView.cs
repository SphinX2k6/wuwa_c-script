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

// Token: 0x02001FE0 RID: 8160
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinShowView : UiTickViewBase
{
	// Token: 0x06014410 RID: 82960 RVA: 0x005E7E3A File Offset: 0x005E603A
	public WeaponSkinShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014411 RID: 82961 RVA: 0x005E7E5C File Offset: 0x005E605C
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

	// Token: 0x06014412 RID: 82962 RVA: 0x005E7F34 File Offset: 0x005E6134
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

	// Token: 0x06014413 RID: 82963 RVA: 0x005E805C File Offset: 0x005E625C
	protected override UniTask OnHandlePostLoadSceneAsync(bool isSceneLoad)
	{
		WeaponSkinShowView.<OnHandlePostLoadSceneAsync>d__11 <OnHandlePostLoadSceneAsync>d__;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHandlePostLoadSceneAsync>d__.<>4__this = this;
		<OnHandlePostLoadSceneAsync>d__.<>1__state = -1;
		<OnHandlePostLoadSceneAsync>d__.<>t__builder.Start<WeaponSkinShowView.<OnHandlePostLoadSceneAsync>d__11>(ref <OnHandlePostLoadSceneAsync>d__);
		return <OnHandlePostLoadSceneAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014414 RID: 82964 RVA: 0x005E80A0 File Offset: 0x005E62A0
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

	// Token: 0x06014415 RID: 82965 RVA: 0x005E80F6 File Offset: 0x005E62F6
	private WeaponSkinPreviewGridItem CreateSkinGridItem()
	{
		WeaponSkinPreviewGridItem weaponSkinPreviewGridItem = new WeaponSkinPreviewGridItem();
		weaponSkinPreviewGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnClickSkinGridItem));
		return weaponSkinPreviewGridItem;
	}

	// Token: 0x06014416 RID: 82966 RVA: 0x005E8110 File Offset: 0x005E6310
	private void OnClickSkinGridItem(MediumItemGridExtendCallback parameters)
	{
		WeaponSkinData weaponSkinData = parameters.Data as WeaponSkinData;
		if (weaponSkinData == null)
		{
			return;
		}
		this.SwitchSkin(weaponSkinData.SkinId);
	}

	// Token: 0x06014417 RID: 82967 RVA: 0x005E8139 File Offset: 0x005E6339
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

	// Token: 0x06014418 RID: 82968 RVA: 0x005E8177 File Offset: 0x005E6377
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

	// Token: 0x06014419 RID: 82969 RVA: 0x005E8198 File Offset: 0x005E6398
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

	// Token: 0x0601441A RID: 82970 RVA: 0x005E81F4 File Offset: 0x005E63F4
	private void RefreshText(int skinId)
	{
		WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(skinId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), weaponSkinConfig.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), weaponSkinConfig.BgDescription, Array.Empty<object>());
	}

	// Token: 0x0601441B RID: 82971 RVA: 0x005E8247 File Offset: 0x005E6447
	private void OnClickHideToggle(EToggleState toggleState)
	{
		UUIItem item = base.GetItem(1);
		item.SetUIActive(!item.bIsUIActive);
	}

	// Token: 0x0601441C RID: 82972 RVA: 0x005E825E File Offset: 0x005E645E
	private void OnCloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400ABC1 RID: 43969
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400ABC2 RID: 43970
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<WeaponSkinPreviewGridItem, WeaponSkinData> SkinScrollView;

	// Token: 0x0400ABC3 RID: 43971
	private List<WeaponSkinData> SkinDataList = new List<WeaponSkinData>();

	// Token: 0x0400ABC4 RID: 43972
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x0400ABC5 RID: 43973
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x0400ABC6 RID: 43974
	private readonly WeaponTrialData TrialWeaponData = new WeaponTrialData();

	// Token: 0x0400ABC7 RID: 43975
	private int CurrentSkinId;

	// Token: 0x020082EA RID: 33514
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A4D6 RID: 173270
		CaptionItem,
		// Token: 0x0402A4D7 RID: 173271
		HideRootItem,
		// Token: 0x0402A4D8 RID: 173272
		TitleText,
		// Token: 0x0402A4D9 RID: 173273
		DescText,
		// Token: 0x0402A4DA RID: 173274
		HideToggle,
		// Token: 0x0402A4DB RID: 173275
		LoopScrollView,
		// Token: 0x0402A4DC RID: 173276
		WeaponSkinItem
	}
}
