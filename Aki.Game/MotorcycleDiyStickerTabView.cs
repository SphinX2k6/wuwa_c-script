using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Motorcycle.Model;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022A3 RID: 8867
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyStickerTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001623 RID: 5667
	// (get) Token: 0x06011571 RID: 71025 RVA: 0x0043CBBF File Offset: 0x0043ADBF
	// (set) Token: 0x06011572 RID: 71026 RVA: 0x0043CBC7 File Offset: 0x0043ADC7
	[Nullable(2)]
	public Action<int> OnTabCameraClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001624 RID: 5668
	// (get) Token: 0x06011573 RID: 71027 RVA: 0x0043CBD0 File Offset: 0x0043ADD0
	// (set) Token: 0x06011574 RID: 71028 RVA: 0x0043CBD8 File Offset: 0x0043ADD8
	[Nullable(2)]
	public Action<EOutlookType, int, int> OnSelectItemClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x06011575 RID: 71029 RVA: 0x0043CBE4 File Offset: 0x0043ADE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnJumpClick)),
			new ValueTuple<int, Delegate>(14, new Action(this.OnBtnOverviewClick))
		};
	}

	// Token: 0x06011576 RID: 71030 RVA: 0x0043CDA4 File Offset: 0x0043AFA4
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyStickerTabView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyStickerTabView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011577 RID: 71031 RVA: 0x0043CDE8 File Offset: 0x0043AFE8
	protected override void OnBeforeShow()
	{
		int index = (this.CurrentSelectStickerPart > 0) ? (this.CurrentSelectStickerPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x06011578 RID: 71032 RVA: 0x0043CE18 File Offset: 0x0043B018
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x06011579 RID: 71033 RVA: 0x0043CE36 File Offset: 0x0043B036
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x0601157A RID: 71034 RVA: 0x0043CE54 File Offset: 0x0043B054
	private MotorcycleDiyPartTabItem InitStickerTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0601157B RID: 71035 RVA: 0x0043CE5C File Offset: 0x0043B05C
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Sticker, new int?(motorcycleDiyPartTabItemData.PartId));
		this.CurrentSelectStickerPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
		Action<int> onTabCameraClick = this.OnTabCameraClick;
		if (onTabCameraClick == null)
		{
			return;
		}
		onTabCameraClick(this.CurrentSelectStickerPart);
	}

	// Token: 0x0601157C RID: 71036 RVA: 0x0043CEBB File Offset: 0x0043B0BB
	private MotorcycleDiyStickerDecoItem CreateStickerItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickSticker)
		};
	}

	// Token: 0x0601157D RID: 71037 RVA: 0x0043CED4 File Offset: 0x0043B0D4
	public void RefreshItemScrollView()
	{
		if (this.StickerScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectStickerPart, true);
		}
	}

	// Token: 0x0601157E RID: 71038 RVA: 0x0043CEEC File Offset: 0x0043B0EC
	private List<MotorcycleDiyStickerDecoItemData> GetStickerItemDataList(int partId)
	{
		List<MotorcycleDiyStickerDecoItemData> list = new List<MotorcycleDiyStickerDecoItemData>();
		list.Add(new MotorcycleDiyStickerDecoItemData
		{
			Part = partId,
			ItemId = 0,
			IsSticker = true
		});
		int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedStickerId(partId));
		if (num != null && num.Value > 0)
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num.Value);
			list.Add(new MotorcycleDiyStickerDecoItemData
			{
				Part = partId,
				ItemId = num.Value,
				QualityId = ((motorStickerConfig != null) ? motorStickerConfig.Value.QualityId : 0),
				SortIndex = ((motorStickerConfig != null) ? motorStickerConfig.Value.SortIndex : 0),
				IsSticker = true
			});
		}
		foreach (int num2 in MotorcycleDiyModel.Instance.GetCanUseStickerIdsInRegion())
		{
			MotorSticker? motorStickerConfig2 = MotorDiyConfig.Instance.GetMotorStickerConfig(num2);
			if (motorStickerConfig2 != null && motorStickerConfig2.Value.PartId == partId)
			{
				EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(num2);
				if (stickerState != EOutLookState.IsHide && stickerState != EOutLookState.IsEquipped)
				{
					list.Add(new MotorcycleDiyStickerDecoItemData
					{
						Part = partId,
						ItemId = num2,
						QualityId = motorStickerConfig2.Value.QualityId,
						SortIndex = motorStickerConfig2.Value.SortIndex,
						IsSticker = true
					});
				}
			}
		}
		return list;
	}

	// Token: 0x0601157F RID: 71039 RVA: 0x0043D0B8 File Offset: 0x0043B2B8
	private int GetStickerSortPriority(MotorcycleDiyStickerDecoItemData data)
	{
		if (data.ItemId == 0)
		{
			return 0;
		}
		EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(data.ItemId);
		if (stickerState == EOutLookState.IsEquipped)
		{
			return 1;
		}
		if (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(data.ItemId))
		{
			return 2;
		}
		if (stickerState == EOutLookState.CanEquipped)
		{
			return 3;
		}
		if (stickerState == EOutLookState.IsLock)
		{
			return 4;
		}
		if (stickerState == EOutLookState.IsBan)
		{
			return 5;
		}
		return 6;
	}

	// Token: 0x06011580 RID: 71040 RVA: 0x0043D110 File Offset: 0x0043B310
	private int SortStickerItemFunc(MotorcycleDiyStickerDecoItemData dataA, MotorcycleDiyStickerDecoItemData dataB)
	{
		int stickerSortPriority = this.GetStickerSortPriority(dataA);
		int stickerSortPriority2 = this.GetStickerSortPriority(dataB);
		if (stickerSortPriority != stickerSortPriority2)
		{
			return stickerSortPriority - stickerSortPriority2;
		}
		int qualityId = dataA.QualityId;
		int qualityId2 = dataB.QualityId;
		if (qualityId != qualityId2)
		{
			return qualityId2 - qualityId;
		}
		int sortIndex = dataA.SortIndex;
		return dataB.SortIndex - sortIndex;
	}

	// Token: 0x06011581 RID: 71041 RVA: 0x0043D15C File Offset: 0x0043B35C
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			List<MotorcycleDiyStickerDecoItemData> stickerDataList = this.GetStickerItemDataList(partId);
			stickerDataList.Sort(new Comparison<MotorcycleDiyStickerDecoItemData>(this.SortStickerItemFunc));
			this.CachedStickerDataList = stickerDataList;
			this.StickerScrollView.RefreshByData(stickerDataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, stickerDataList);
			}, false);
			return;
		}
		this.StickerScrollView.RefreshByData(this.CachedStickerDataList, true, null, false);
	}

	// Token: 0x06011582 RID: 71042 RVA: 0x0043D1EC File Offset: 0x0043B3EC
	private void AutoSelectGridByDataList(int stickerPart, List<MotorcycleDiyStickerDecoItemData> stickerDataList)
	{
		int gridIndex = 0;
		int selectStickerId = 0;
		int selectedStickerId = MotorcycleDiyModel.Instance.GetSelectedStickerId(stickerPart);
		if (selectedStickerId != 0)
		{
			selectStickerId = selectedStickerId;
		}
		else
		{
			int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedStickerId(stickerPart));
			selectStickerId = ((num != null) ? num.Value : 0);
		}
		MotorcycleDiyStickerDecoItemData motorcycleDiyStickerDecoItemData = stickerDataList.FirstOrDefault((MotorcycleDiyStickerDecoItemData data) => data.ItemId == selectStickerId);
		if (motorcycleDiyStickerDecoItemData != null)
		{
			gridIndex = stickerDataList.IndexOf(motorcycleDiyStickerDecoItemData);
		}
		if (!this.StickerScrollView.IsGridDisplaying(gridIndex))
		{
			this.StickerScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.StickerScrollView.DeselectCurrentGridProxy(false);
		this.StickerScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06011583 RID: 71043 RVA: 0x0043D29D File Offset: 0x0043B49D
	private void OnStickerInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Sticker, new int?(this.CurrentSelectStickerPart));
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
	}

	// Token: 0x06011584 RID: 71044 RVA: 0x0043D2C4 File Offset: 0x0043B4C4
	private void OnClickSticker(int stickerId, UUIExtendToggle toggle, UUIItem newItem)
	{
		EOutLookState stickerState = MotorcycleDiyModel.Instance.GetStickerState(stickerId);
		if (stickerState == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = MotorcycleDiyModel.Instance.GetBanTips(EOutlookType.Sticker, stickerId);
			if (banTips != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYWarning01", new object[]
				{
					banTips.Value.Item1,
					banTips.Value.Item2
				});
			}
			return;
		}
		if (this.CurrentSelectToggle != null)
		{
			this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		this.UiViewSequence.StopSequenceByKey("Switch", false, false);
		this.UiViewSequence.PlaySequencePurely("Switch", false, false);
		if (stickerId == 0)
		{
			MotorcycleUiModelUtil.Instance.SetEmptySticker(this.CurrentSelectStickerPart);
		}
		else
		{
			MotorcycleUiModelUtil.Instance.AddMaterialByStickerId(stickerId);
		}
		bool flag = MotorcycleDiyModel.Instance.IsEquipDefaultSticker(this.CurrentSelectStickerPart);
		bool flag2 = stickerId == 0 && !flag;
		MotorcycleDiyModel.Instance.SetSelectStickerInfo(this.CurrentSelectStickerPart, stickerId);
		if (stickerState == EOutLookState.CanEquipped || flag2)
		{
			List<int> selectedStickerIdList = MotorcycleDiyModel.Instance.GetSelectedStickerIdList(true);
			MotorcycleDiyController.Instance.EquipMotorStickerRequest(selectedStickerIdList, null);
		}
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Sticker, this.CurrentSelectStickerPart, stickerId);
		}
		EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
		UUIItem item = base.GetItem(7);
		UUIItem item2 = base.GetItem(10);
		UUIItem item3 = base.GetItem(12);
		UUIText text = base.GetText(11);
		UUIButtonComponent button = base.GetButton(9);
		UUIText text2 = base.GetText(13);
		UUIText text3 = base.GetText(6);
		UUIText text4 = base.GetText(8);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		item3.SetUIActive(false);
		button.RootUIComp.Get().SetUIActive(false);
		if (stickerId <= 0)
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorEmptyStickerName");
			string stringConfig2 = ConfigCommonParamById.GetStringConfig("MotorEmptyStickerType");
			text4.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text4, stringConfig2, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text3, stringConfig, Array.Empty<object>());
			return;
		}
		MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(stickerId);
		if (motorStickerConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text4, motorStickerConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text3, motorStickerConfig.Value.Title, Array.Empty<object>());
		base.GetItem(7).SetUIActive(stickerState == EOutLookState.IsLock);
		int[] itemAccessArray = motorStickerConfig.Value.GetItemAccessArray();
		if (itemAccessArray == null || itemAccessArray.Length == 0)
		{
			return;
		}
		int num = itemAccessArray[0];
		if (num == 0)
		{
			return;
		}
		AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(num);
		if (accessPathConfig == null)
		{
			return;
		}
		this.JumpId = num;
		ESkipName skipName = (ESkipName)accessPathConfig.Value.SkipName;
		button.RootUIComp.Get().SetUIActive(skipName != ESkipName.NoSkip && stickerState == EOutLookState.IsLock);
		item3.SetUIActive(stickerState == EOutLookState.IsLock);
		item2.SetUIActive(skipName == ESkipName.NoSkip && stickerState == EOutLookState.IsLock);
		LguiUtil.Instance.SetLocalTextNew(text, accessPathConfig.Value.Description, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text2, accessPathConfig.Value.Description, Array.Empty<object>());
	}

	// Token: 0x06011585 RID: 71045 RVA: 0x0043D636 File Offset: 0x0043B836
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x06011586 RID: 71046 RVA: 0x0043D650 File Offset: 0x0043B850
	private void OnBtnOverviewClick()
	{
		List<object> list = new List<object>();
		list.Add(EOutlookType.Sticker);
		list.Add(this.CurrentSelectStickerPart);
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyOverviewView, list, null);
	}

	// Token: 0x040083CF RID: 33743
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x040083D0 RID: 33744
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> StickerScrollView;

	// Token: 0x040083D1 RID: 33745
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040083D2 RID: 33746
	private List<MotorcycleDiyStickerDecoItemData> CachedStickerDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x040083D3 RID: 33747
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083D4 RID: 33748
	private int CurrentSelectStickerPart;

	// Token: 0x040083D5 RID: 33749
	private int JumpId;

	// Token: 0x020087EE RID: 34798
	[NullableContext(0)]
	private class EMotorStickerScrollViewComponent
	{
		// Token: 0x0402C2C6 RID: 180934
		public const int TabContent = 0;

		// Token: 0x0402C2C7 RID: 180935
		public const int TabItem = 1;

		// Token: 0x0402C2C8 RID: 180936
		public const int LoopScrollView = 2;

		// Token: 0x0402C2C9 RID: 180937
		public const int SVContent = 3;

		// Token: 0x0402C2CA RID: 180938
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x0402C2CB RID: 180939
		public const int RightLayout = 5;

		// Token: 0x0402C2CC RID: 180940
		public const int TxtStickerName = 6;

		// Token: 0x0402C2CD RID: 180941
		public const int LockItem = 7;

		// Token: 0x0402C2CE RID: 180942
		public const int TxtCurEquip = 8;

		// Token: 0x0402C2CF RID: 180943
		public const int BtnJump = 9;

		// Token: 0x0402C2D0 RID: 180944
		public const int TipsItem = 10;

		// Token: 0x0402C2D1 RID: 180945
		public const int TxtTipsName = 11;

		// Token: 0x0402C2D2 RID: 180946
		public const int TitleGetItem = 12;

		// Token: 0x0402C2D3 RID: 180947
		public const int TxtJump = 13;

		// Token: 0x0402C2D4 RID: 180948
		public const int BtnOverview = 14;

		// Token: 0x0402C2D5 RID: 180949
		public const int MenuItem = 15;

		// Token: 0x0402C2D6 RID: 180950
		public const int SmallTitleItem = 16;

		// Token: 0x0402C2D7 RID: 180951
		public const int NormalPanel = 17;

		// Token: 0x0402C2D8 RID: 180952
		public const int EditPresetPanel = 18;
	}
}
