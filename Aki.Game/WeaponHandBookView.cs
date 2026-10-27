using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E4C RID: 7756
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookView : UiViewBase
{
	// Token: 0x0600EBD3 RID: 60371 RVA: 0x0037F513 File Offset: 0x0037D713
	public WeaponHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.WeaponIdList = new List<int>();
		this.WeaponSkinIdList = new List<int>();
	}

	// Token: 0x0600EBD4 RID: 60372 RVA: 0x0037F540 File Offset: 0x0037D740
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

	// Token: 0x0600EBD5 RID: 60373 RVA: 0x0037F72C File Offset: 0x0037D92C
	private UniTask InitCaptionItemAsync()
	{
		WeaponHandBookView.<InitCaptionItemAsync>d__18 <InitCaptionItemAsync>d__;
		<InitCaptionItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItemAsync>d__.<>4__this = this;
		<InitCaptionItemAsync>d__.<>1__state = -1;
		<InitCaptionItemAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitCaptionItemAsync>d__18>(ref <InitCaptionItemAsync>d__);
		return <InitCaptionItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBD6 RID: 60374 RVA: 0x0037F770 File Offset: 0x0037D970
	private UniTask InitWeaponDetailTipsViewAsync()
	{
		WeaponHandBookView.<InitWeaponDetailTipsViewAsync>d__19 <InitWeaponDetailTipsViewAsync>d__;
		<InitWeaponDetailTipsViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponDetailTipsViewAsync>d__.<>4__this = this;
		<InitWeaponDetailTipsViewAsync>d__.<>1__state = -1;
		<InitWeaponDetailTipsViewAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitWeaponDetailTipsViewAsync>d__19>(ref <InitWeaponDetailTipsViewAsync>d__);
		return <InitWeaponDetailTipsViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBD7 RID: 60375 RVA: 0x0037F7B4 File Offset: 0x0037D9B4
	private UniTask InitWeaponGenericLayoutAsync()
	{
		WeaponHandBookView.<InitWeaponGenericLayoutAsync>d__20 <InitWeaponGenericLayoutAsync>d__;
		<InitWeaponGenericLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitWeaponGenericLayoutAsync>d__.<>4__this = this;
		<InitWeaponGenericLayoutAsync>d__.<>1__state = -1;
		<InitWeaponGenericLayoutAsync>d__.<>t__builder.Start<WeaponHandBookView.<InitWeaponGenericLayoutAsync>d__20>(ref <InitWeaponGenericLayoutAsync>d__);
		return <InitWeaponGenericLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBD8 RID: 60376 RVA: 0x0037F7F8 File Offset: 0x0037D9F8
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponHandBookView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponHandBookView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EBD9 RID: 60377 RVA: 0x0037F83C File Offset: 0x0037DA3C
	protected override void OnStart()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
		this.WeaponIdList = HandBookModel.Instance.GetAllHandBookWeaponIdList().ToList<int>();
		this.WeaponSkinIdList = HandBookModel.Instance.GetAllHandBookWeaponSkinIdList().ToList<int>();
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

	// Token: 0x0600EBDA RID: 60378 RVA: 0x0037F8AE File Offset: 0x0037DAAE
	private WeaponHandBookItem CreateNodeGrid(WeaponHandBookDynamicData data, UUIItem uiItem, int index)
	{
		return new WeaponHandBookItem
		{
			OnClickCallBack = new Action<UUIExtendToggle, int>(this.OnClickWeaponItemCallBack)
		};
	}

	// Token: 0x0600EBDB RID: 60379 RVA: 0x0037F8C7 File Offset: 0x0037DAC7
	private HandBookTab InitTabItem()
	{
		return new HandBookTab
		{
			OnClickCallBack = new Action<UUIExtendToggle, int>(this.OnClickTabCallBack)
		};
	}

	// Token: 0x0600EBDC RID: 60380 RVA: 0x0037F8E0 File Offset: 0x0037DAE0
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
		HandBookModel instance = HandBookModel.Instance;
		WeaponHandBookDynamicData weaponHandBookDynamicData3 = list2.ElementAtOrDefault(1);
		int? num2;
		if (weaponHandBookDynamicData3 == null)
		{
			num2 = null;
		}
		else
		{
			List<WeaponHandBookDynamicLayoutItemData> itemData = weaponHandBookDynamicData3.ItemData;
			if (itemData == null)
			{
				num2 = null;
			}
			else
			{
				WeaponHandBookDynamicLayoutItemData weaponHandBookDynamicLayoutItemData = itemData.ElementAtOrDefault(0);
				num2 = ((weaponHandBookDynamicLayoutItemData != null) ? weaponHandBookDynamicLayoutItemData.ItemId : null);
			}
		}
		int? num3 = num2;
		instance.CurrentSelectWeaponHandBookId = num3.GetValueOrDefault();
		DynamicScrollView<WeaponHandBookItem, WeaponHandBookDynamicItem, WeaponHandBookDynamicData> weaponGenericLayout = this.WeaponGenericLayout;
		if (weaponGenericLayout == null)
		{
			return;
		}
		weaponGenericLayout.RefreshByData(list2.ToArray(), false, false);
	}

	// Token: 0x0600EBDD RID: 60381 RVA: 0x0037FC30 File Offset: 0x0037DE30
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

	// Token: 0x0600EBDE RID: 60382 RVA: 0x0037FC94 File Offset: 0x0037DE94
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

	// Token: 0x0600EBDF RID: 60383 RVA: 0x0037FD4D File Offset: 0x0037DF4D
	private void UpdateWeaponDetail(WeaponTrialData curData)
	{
		this.WeaponDetailTipsView.UpdateComponent(curData);
	}

	// Token: 0x0600EBE0 RID: 60384 RVA: 0x0037FD5C File Offset: 0x0037DF5C
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

	// Token: 0x0600EBE1 RID: 60385 RVA: 0x0037FE10 File Offset: 0x0037E010
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

	// Token: 0x0600EBE2 RID: 60386 RVA: 0x0037FE78 File Offset: 0x0037E078
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

	// Token: 0x0600EBE3 RID: 60387 RVA: 0x0037FF68 File Offset: 0x0037E168
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

	// Token: 0x0600EBE4 RID: 60388 RVA: 0x00380000 File Offset: 0x0037E200
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

	// Token: 0x0600EBE5 RID: 60389 RVA: 0x003800E0 File Offset: 0x0037E2E0
	private void OnFullToggleClick(EToggleState toggleState)
	{
		this.ChangeWeapon(null);
		this.RefeshView();
	}

	// Token: 0x0600EBE6 RID: 60390 RVA: 0x00380104 File Offset: 0x0037E304
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

	// Token: 0x0600EBE7 RID: 60391 RVA: 0x00380170 File Offset: 0x0037E370
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

	// Token: 0x04006D58 RID: 27992
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006D59 RID: 27993
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<WeaponHandBookItem, WeaponHandBookDynamicItem, WeaponHandBookDynamicData> WeaponGenericLayout;

	// Token: 0x04006D5A RID: 27994
	[Nullable(2)]
	private WeaponHandBookDynamicItem WeaponBaseItem;

	// Token: 0x04006D5B RID: 27995
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<HandBookTab, int> TabScrollview;

	// Token: 0x04006D5C RID: 27996
	[Nullable(2)]
	private FilterSortEntrance<int> FilterBtn;

	// Token: 0x04006D5D RID: 27997
	private List<int> WeaponIdList;

	// Token: 0x04006D5E RID: 27998
	private List<int> WeaponSkinIdList;

	// Token: 0x04006D5F RID: 27999
	[Nullable(2)]
	private UUIExtendToggle CurrentTabToggle;

	// Token: 0x04006D60 RID: 28000
	[Nullable(2)]
	private UUIExtendToggle CurrentWeaponToggle;

	// Token: 0x04006D61 RID: 28001
	private int CurrentShowType;

	// Token: 0x04006D62 RID: 28002
	[Nullable(2)]
	private SkeletalObserverHandle WeaponObserver;

	// Token: 0x04006D63 RID: 28003
	[Nullable(2)]
	private SkeletalObserverHandle WeaponScabbardObserver;

	// Token: 0x04006D64 RID: 28004
	[Nullable(2)]
	private WeaponDetailTipsComponent WeaponDetailTipsView;

	// Token: 0x04006D65 RID: 28005
	private int CurrentId;

	// Token: 0x04006D66 RID: 28006
	private readonly bool NeedMeshStreaming;

	// Token: 0x04006D67 RID: 28007
	private readonly WeaponTrialData TrialWeaponData = new WeaponTrialData();

	// Token: 0x04006D68 RID: 28008
	private bool IsInternal;

	// Token: 0x020083FC RID: 33788
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402AF64 RID: 175972
		public const int CaptionItem = 0;

		// Token: 0x0402AF65 RID: 175973
		public const int TabScrollView = 1;

		// Token: 0x0402AF66 RID: 175974
		public const int TabItem = 2;

		// Token: 0x0402AF67 RID: 175975
		public const int DragItem = 3;

		// Token: 0x0402AF68 RID: 175976
		public const int CollectText = 4;

		// Token: 0x0402AF69 RID: 175977
		public const int CollectNumText = 5;

		// Token: 0x0402AF6A RID: 175978
		public const int WeaponScrollView = 6;

		// Token: 0x0402AF6B RID: 175979
		public const int WeaponScrollItem = 7;

		// Token: 0x0402AF6C RID: 175980
		public const int SortFilterItem = 8;

		// Token: 0x0402AF6D RID: 175981
		public const int WeaponDetailsItem = 9;

		// Token: 0x0402AF6E RID: 175982
		public const int SkinDetailsItem = 10;

		// Token: 0x0402AF6F RID: 175983
		public const int SkinTitleText = 11;

		// Token: 0x0402AF70 RID: 175984
		public const int SkinDesText = 12;

		// Token: 0x0402AF71 RID: 175985
		public const int CheckToggle = 13;

		// Token: 0x0402AF72 RID: 175986
		public const int FullLevelToggle = 14;

		// Token: 0x0402AF73 RID: 175987
		public const int LeftItem = 15;

		// Token: 0x0402AF74 RID: 175988
		public const int RightItem = 16;

		// Token: 0x0402AF75 RID: 175989
		public const int FullLevelToggleRootItem = 17;
	}
}
