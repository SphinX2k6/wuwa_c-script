using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200130E RID: 4878
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookView : UiViewBase
{
	// Token: 0x0600BFF2 RID: 49138 RVA: 0x0038B1A3 File Offset: 0x003893A3
	public WeaponHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.WeaponIdList = new List<int>();
		this.WeaponSkinIdList = new List<int>();
	}

	// Token: 0x0600BFF3 RID: 49139 RVA: 0x0038B1D0 File Offset: 0x003893D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(14, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(13, new Action<EToggleState>(this.EnterInternalView)),
			new ValueTuple<int, Delegate>(14, new Action<EToggleState>(this.OnFullToggleClick))
		};
	}

	// Token: 0x0600BFF4 RID: 49140 RVA: 0x0038B3BC File Offset: 0x003895BC
	private UniTask InitCaptionItemAsync()
	{
		WeaponHandBookView.<InitCaptionItemAsync>d__18 <InitCaptionItemAsync>d__;
		<InitCaptionItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItemAsync>d__.<>4__this = this;
		<InitCaptionItemAsync>d__.<>1__state = -1;
		<InitCaptionItemAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitCaptionItemAsync>d__18>(ref <InitCaptionItemAsync>d__);
		return <InitCaptionItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x0038B400 File Offset: 0x00389600
	private UniTask InitWeaponDetailTipsViewAsync()
	{
		WeaponHandBookView.<InitWeaponDetailTipsViewAsync>d__19 <InitWeaponDetailTipsViewAsync>d__;
		<InitWeaponDetailTipsViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponDetailTipsViewAsync>d__.<>4__this = this;
		<InitWeaponDetailTipsViewAsync>d__.<>1__state = -1;
		<InitWeaponDetailTipsViewAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitWeaponDetailTipsViewAsync>d__19>(ref <InitWeaponDetailTipsViewAsync>d__);
		return <InitWeaponDetailTipsViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x0038B444 File Offset: 0x00389644
	private UniTask InitWeaponGenericLayoutAsync()
	{
		WeaponHandBookView.<InitWeaponGenericLayoutAsync>d__20 <InitWeaponGenericLayoutAsync>d__;
		<InitWeaponGenericLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponGenericLayoutAsync>d__.<>4__this = this;
		<InitWeaponGenericLayoutAsync>d__.<>1__state = -1;
		<InitWeaponGenericLayoutAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitWeaponGenericLayoutAsync>d__20>(ref <InitWeaponGenericLayoutAsync>d__);
		return <InitWeaponGenericLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x0038B488 File Offset: 0x00389688
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponHandBookView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponHandBookView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x0038B4CC File Offset: 0x003896CC
	protected override void OnStart()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
		this.WeaponIdList = new List<int>(HandBookModel.Instance.GetAllHandBookWeaponIdList());
		this.WeaponSkinIdList = new List<int>(HandBookModel.Instance.GetAllHandBookWeaponSkinIdList());
		GenericScrollViewNew<HandBookTab, int> tabScrollview = this.TabScrollview;
		if (tabScrollview == null)
		{
			return;
		}
		tabScrollview.RefreshByData(new List<int>
		{
			0,
			1
		}, delegate
		{
			GenericScrollViewNew<HandBookTab, int> tabScrollview2 = this.TabScrollview;
			if (tabScrollview2 == null)
			{
				return;
			}
			HandBookTab scrollItemByIndex = tabScrollview2.GetScrollItemByIndex(0);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.SelectToggle();
		}, false);
	}

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x0038B53E File Offset: 0x0038973E
	private WeaponHandBookItem CreateNodeGrid(WeaponHandBookDynamicData data, UUIItem uiItem, int index)
	{
		return new WeaponHandBookItem
		{
			OnClickCallBack = new Action<UUIExtendToggle, int>(this.OnClickWeaponItemCallBack)
		};
	}

	// Token: 0x0600BFFA RID: 49146 RVA: 0x0038B557 File Offset: 0x00389757
	private HandBookTab InitTabItem()
	{
		return new HandBookTab
		{
			OnClickCallBack = new Action<UUIExtendToggle, int>(this.OnClickTabCallBack)
		};
	}

	// Token: 0x0600BFFB RID: 49147 RVA: 0x0038B570 File Offset: 0x00389770
	private void OnFilterUpdate(List<int> list, bool isOutSideChange, EFilterSortType OperationType)
	{
		if (list == null || list.Count <= 0)
		{
			base.GetUIDynScrollViewComponent(6).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetUIDynScrollViewComponent(6).RootUIComp.Get().SetUIActive(true);
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		if (this.CurrentShowType == 0)
		{
			foreach (int itemId in list)
			{
				WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
				if (weaponConfigByItemId != null)
				{
					if (!dictionary.ContainsKey(weaponConfigByItemId.Value.WeaponType))
					{
						dictionary[weaponConfigByItemId.Value.WeaponType] = new List<int>();
					}
					dictionary[weaponConfigByItemId.Value.WeaponType].Add(weaponConfigByItemId.Value.ItemId);
				}
			}
		}
		if (this.CurrentShowType == 1)
		{
			foreach (int id in list)
			{
				WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(id);
				if (!dictionary.ContainsKey(weaponSkinConfig.WeaponSkinType))
				{
					dictionary[weaponSkinConfig.WeaponSkinType] = new List<int>();
				}
				dictionary[weaponSkinConfig.WeaponSkinType].Add(weaponSkinConfig.Id);
			}
		}
		List<WeaponHandBookDynamicData> list2 = new List<WeaponHandBookDynamicData>();
		bool isSkin = this.CurrentShowType == 1;
		List<int> list3 = new List<int>(dictionary.Keys);
		list3.Sort((int a, int b) => a - b);
		foreach (int num in list3)
		{
			List<int> list4 = dictionary[num];
			WeaponHandBookDynamicData weaponHandBookDynamicData = new WeaponHandBookDynamicData();
			list2.Add(weaponHandBookDynamicData);
			weaponHandBookDynamicData.TitleId = (WeaponConfig.Instance.GetWeaponTypeName(num) ?? "");
			WeaponHandBookDynamicData weaponHandBookDynamicData2 = new WeaponHandBookDynamicData();
			List<WeaponHandBookDynamicLayoutItemData> list5 = new List<WeaponHandBookDynamicLayoutItemData>();
			foreach (int value in list4)
			{
				list5.Add(new WeaponHandBookDynamicLayoutItemData
				{
					IsSkin = isSkin,
					ItemId = new int?(value)
				});
			}
			weaponHandBookDynamicData2.ItemData = list5;
			list2.Add(weaponHandBookDynamicData2);
		}
		if (list2.Count <= 0)
		{
			this.RefeshView();
			return;
		}
		WeaponHandBookDynamicData weaponHandBookDynamicData3 = (list2.Count > 1) ? list2[1] : null;
		List<WeaponHandBookDynamicLayoutItemData> list6 = (weaponHandBookDynamicData3 != null) ? weaponHandBookDynamicData3.ItemData : null;
		HandBookModel instance = HandBookModel.Instance;
		int currentSelectWeaponHandBookId;
		if (list6 == null || list6.Count <= 0)
		{
			currentSelectWeaponHandBookId = 0;
		}
		else
		{
			WeaponHandBookDynamicLayoutItemData weaponHandBookDynamicLayoutItemData = list6[0];
			currentSelectWeaponHandBookId = ((weaponHandBookDynamicLayoutItemData != null) ? weaponHandBookDynamicLayoutItemData.ItemId : null).GetValueOrDefault();
		}
		instance.CurrentSelectWeaponHandBookId = currentSelectWeaponHandBookId;
		DynamicScrollView<WeaponHandBookItem, WeaponHandBookDynamicItem, WeaponHandBookDynamicData> weaponGenericLayout = this.WeaponGenericLayout;
		if (weaponGenericLayout == null)
		{
			return;
		}
		weaponGenericLayout.RefreshByData(list2.ToArray(), false, false);
	}

	// Token: 0x0600BFFC RID: 49148 RVA: 0x0038B8C8 File Offset: 0x00389AC8
	private void RefeshView()
	{
		if (this.CurrentShowType == 0)
		{
			base.GetItem(9).SetUIActive(true);
			base.GetItem(10).SetUIActive(false);
			this.RefeshWeaponView();
		}
		if (this.CurrentShowType == 1)
		{
			base.GetItem(9).SetUIActive(false);
			base.GetItem(10).SetUIActive(true);
			this.RefeshWeaponSkinView();
		}
	}

	// Token: 0x0600BFFD RID: 49149 RVA: 0x0038B92C File Offset: 0x00389B2C
	private void RefeshWeaponView()
	{
		if (this.CurrentId == 0)
		{
			return;
		}
		if (WeaponConfig.Instance.GetWeaponConfigByItemId(this.CurrentId) == null)
		{
			return;
		}
		base.GetItem(17).SetUIActive(true);
		WeaponTrialData curData = (this.CurrentShowType == 0 && base.GetExtendToggle(14).GetToggleState() == EToggleState.ETT_Checked) ? this.TrialWeaponData.GetFullLevelWeaponData() : this.TrialWeaponData;
		this.UpdateWeaponDetail(curData);
		int num = HandBookModel.Instance.GetAllHandBookWeaponIdList().Length;
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(num.ToString(), true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeaponHandBook_Weapon_Name", Array.Empty<object>());
	}

	// Token: 0x0600BFFE RID: 49150 RVA: 0x0038B9E5 File Offset: 0x00389BE5
	private void UpdateWeaponDetail(WeaponTrialData curData)
	{
		this.WeaponDetailTipsView.UpdateComponent(curData);
	}

	// Token: 0x0600BFFF RID: 49151 RVA: 0x0038B9F4 File Offset: 0x00389BF4
	private void RefeshWeaponSkinView()
	{
		if (this.CurrentId == 0)
		{
			return;
		}
		WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(this.CurrentId);
		base.GetItem(17).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), weaponSkinConfig.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), weaponSkinConfig.BgDescription, Array.Empty<object>());
		int num = HandBookModel.Instance.GetAllHandBookWeaponSkinIdList().Length;
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(num.ToString(), true);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeaponHandBook_WeaponSkin_Name", Array.Empty<object>());
	}

	// Token: 0x0600C000 RID: 49152 RVA: 0x0038BAA8 File Offset: 0x00389CA8
	private void OnClickWeaponItemCallBack(UUIExtendToggle toggle, int id)
	{
		if (this.CurrentWeaponToggle != toggle)
		{
			UUIExtendToggle currentWeaponToggle = this.CurrentWeaponToggle;
			if (currentWeaponToggle != null)
			{
				currentWeaponToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.CurrentWeaponToggle = toggle;
		if (this.CurrentId == id)
		{
			return;
		}
		this.ChangeWeapon(new int?(id));
		HandBookModel.Instance.CurrentSelectWeaponHandBookId = id;
		this.CurrentId = id;
		this.RefeshView();
		this.ReadWeaponHandBook(id);
	}

	// Token: 0x0600C001 RID: 49153 RVA: 0x0038BB10 File Offset: 0x00389D10
	private void ChangeWeapon(int? id = null)
	{
		int skinId = -1;
		if (this.CurrentShowType == 0 && id != null && id.GetValueOrDefault() != 0)
		{
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(id.Value);
			this.TrialWeaponData.SetTrialId(weaponConfigByItemId.Value.HandBookTrialId, true);
		}
		if (this.CurrentShowType == 1 && id != null && id.GetValueOrDefault() != 0)
		{
			WeaponSkin weaponSkinConfig = WeaponConfig.Instance.GetWeaponSkinConfig(id.Value);
			this.TrialWeaponData.SetTrialId(weaponSkinConfig.HandBookTrialId, true);
			skinId = id.Value;
		}
		WeaponTrialData weaponInstance = (this.CurrentShowType == 0 && base.GetExtendToggle(14).GetToggleState() == EToggleState.ETT_Checked) ? this.TrialWeaponData.GetFullLevelWeaponData() : this.TrialWeaponData;
		WeaponController.Instance.OnSelectedWeaponChange(weaponInstance, this.WeaponObserver, this.WeaponScabbardObserver, skinId, this.NeedMeshStreaming);
	}

	// Token: 0x0600C002 RID: 49154 RVA: 0x0038BC00 File Offset: 0x00389E00
	private void OnClickTabCallBack(UUIExtendToggle toggle, int type)
	{
		UUIExtendToggle currentTabToggle = this.CurrentTabToggle;
		if (currentTabToggle != null)
		{
			currentTabToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentTabToggle = toggle;
		this.CurrentShowType = type;
		if (type == 0)
		{
			FilterSortEntrance<int> filterBtn = this.FilterBtn;
			if (filterBtn != null)
			{
				filterBtn.ClearData(EFilterSortGroupId.WeaponSkinHandBook);
			}
			FilterSortEntrance<int> filterBtn2 = this.FilterBtn;
			if (filterBtn2 != null)
			{
				filterBtn2.UpdateData(EFilterSortGroupId.WeaponHandBook, this.WeaponIdList, Array.Empty<object>());
			}
		}
		if (type == 1)
		{
			FilterSortEntrance<int> filterBtn3 = this.FilterBtn;
			if (filterBtn3 != null)
			{
				filterBtn3.ClearData(EFilterSortGroupId.WeaponHandBook);
			}
			FilterSortEntrance<int> filterBtn4 = this.FilterBtn;
			if (filterBtn4 == null)
			{
				return;
			}
			filterBtn4.UpdateData(EFilterSortGroupId.WeaponSkinHandBook, this.WeaponSkinIdList, Array.Empty<object>());
		}
	}

	// Token: 0x0600C003 RID: 49155 RVA: 0x0038BC98 File Offset: 0x00389E98
	private void EnterInternalView(EToggleState toggleState)
	{
		if (this.IsInternal)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Off", false, null);
			}
			base.GetItem(15).SetUIActive(true);
			base.GetItem(2).SetUIActive(true);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.SetUiActive(true);
			}
			this.RefeshView();
			this.IsInternal = false;
			return;
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 != null)
		{
			uiViewSequence2.PlaySequence("On", false, null);
		}
		base.GetItem(15).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
		base.GetItem(10).SetUIActive(false);
		PopupCaptionItem captionItem2 = this.CaptionItem;
		if (captionItem2 != null)
		{
			captionItem2.SetUiActive(false);
		}
		this.IsInternal = true;
	}

	// Token: 0x0600C004 RID: 49156 RVA: 0x0038BD78 File Offset: 0x00389F78
	private void OnFullToggleClick(EToggleState toggleState)
	{
		this.ChangeWeapon(null);
		this.RefeshView();
	}

	// Token: 0x0600C005 RID: 49157 RVA: 0x0038BD9C File Offset: 0x00389F9C
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyWeaponObserver(this.WeaponObserver);
		this.WeaponObserver = null;
		UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.WeaponScabbardObserver);
		this.WeaponScabbardObserver = null;
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
		FilterSortEntrance<int> filterBtn = this.FilterBtn;
		if (filterBtn != null)
		{
			filterBtn.ClearData(EFilterSortGroupId.WeaponHandBook);
		}
		FilterSortEntrance<int> filterBtn2 = this.FilterBtn;
		if (filterBtn2 == null)
		{
			return;
		}
		filterBtn2.ClearData(EFilterSortGroupId.WeaponSkinHandBook);
	}

	// Token: 0x0600C006 RID: 49158 RVA: 0x0038BE08 File Offset: 0x0038A008
	private void ReadWeaponHandBook(int handBookId)
	{
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Weapon, handBookId);
		if (handBookInfo == null)
		{
			return;
		}
		if (!handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Weapon, handBookId);
		}
	}

	// Token: 0x04006E39 RID: 28217
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006E3A RID: 28218
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<WeaponHandBookItem, WeaponHandBookDynamicItem, WeaponHandBookDynamicData> WeaponGenericLayout;

	// Token: 0x04006E3B RID: 28219
	[Nullable(2)]
	private WeaponHandBookDynamicItem WeaponBaseItem;

	// Token: 0x04006E3C RID: 28220
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<HandBookTab, int> TabScrollview;

	// Token: 0x04006E3D RID: 28221
	[Nullable(2)]
	private FilterSortEntrance<int> FilterBtn;

	// Token: 0x04006E3E RID: 28222
	private List<int> WeaponIdList;

	// Token: 0x04006E3F RID: 28223
	private List<int> WeaponSkinIdList;

	// Token: 0x04006E40 RID: 28224
	[Nullable(2)]
	private UUIExtendToggle CurrentTabToggle;

	// Token: 0x04006E41 RID: 28225
	[Nullable(2)]
	private UUIExtendToggle CurrentWeaponToggle;

	// Token: 0x04006E42 RID: 28226
	private int CurrentShowType;

	// Token: 0x04006E43 RID: 28227
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x04006E44 RID: 28228
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x04006E45 RID: 28229
	[Nullable(2)]
	private WeaponDetailTipsComponent WeaponDetailTipsView;

	// Token: 0x04006E46 RID: 28230
	private int CurrentId;

	// Token: 0x04006E47 RID: 28231
	private readonly bool NeedMeshStreaming;

	// Token: 0x04006E48 RID: 28232
	private readonly WeaponTrialData TrialWeaponData = new WeaponTrialData();

	// Token: 0x04006E49 RID: 28233
	private bool IsInternal;

	// Token: 0x02007581 RID: 30081
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04026288 RID: 156296
		public const int CaptionItem = 0;

		// Token: 0x04026289 RID: 156297
		public const int TabScrollView = 1;

		// Token: 0x0402628A RID: 156298
		public const int TabItem = 2;

		// Token: 0x0402628B RID: 156299
		public const int DragItem = 3;

		// Token: 0x0402628C RID: 156300
		public const int CollectText = 4;

		// Token: 0x0402628D RID: 156301
		public const int CollectNumText = 5;

		// Token: 0x0402628E RID: 156302
		public const int WeaponScrollView = 6;

		// Token: 0x0402628F RID: 156303
		public const int WeaponScrollItem = 7;

		// Token: 0x04026290 RID: 156304
		public const int SortFilterItem = 8;

		// Token: 0x04026291 RID: 156305
		public const int WeaponDetailsItem = 9;

		// Token: 0x04026292 RID: 156306
		public const int SkinDetailsItem = 10;

		// Token: 0x04026293 RID: 156307
		public const int SkinTitleText = 11;

		// Token: 0x04026294 RID: 156308
		public const int SkinDesText = 12;

		// Token: 0x04026295 RID: 156309
		public const int CheckToggle = 13;

		// Token: 0x04026296 RID: 156310
		public const int FullLevelToggle = 14;

		// Token: 0x04026297 RID: 156311
		public const int LeftItem = 15;

		// Token: 0x04026298 RID: 156312
		public const int RightItem = 16;

		// Token: 0x04026299 RID: 156313
		public const int FullLevelToggleRootItem = 17;
	}
}
