using System;
using System.Collections.Generic;
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

// Token: 0x02001787 RID: 6023
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyStickerTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700165A RID: 5722
	// (get) Token: 0x0600EA09 RID: 59913 RVA: 0x004497B7 File Offset: 0x004479B7
	// (set) Token: 0x0600EA0A RID: 59914 RVA: 0x004497BF File Offset: 0x004479BF
	[Nullable(2)]
	public Action<int> OnTabCameraClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700165B RID: 5723
	// (get) Token: 0x0600EA0B RID: 59915 RVA: 0x004497C8 File Offset: 0x004479C8
	// (set) Token: 0x0600EA0C RID: 59916 RVA: 0x004497D0 File Offset: 0x004479D0
	[Nullable(2)]
	public Action<EOutlookType, int, int> OnSelectItemClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x0600EA0D RID: 59917 RVA: 0x004497DC File Offset: 0x004479DC
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

	// Token: 0x0600EA0E RID: 59918 RVA: 0x0044999C File Offset: 0x00447B9C
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyStickerTabView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyStickerTabView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EA0F RID: 59919 RVA: 0x004499E0 File Offset: 0x00447BE0
	protected override void OnBeforeShow()
	{
		int index = (this.CurrentSelectStickerPart > 0) ? (this.CurrentSelectStickerPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0600EA10 RID: 59920 RVA: 0x00449A10 File Offset: 0x00447C10
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x0600EA11 RID: 59921 RVA: 0x00449A2E File Offset: 0x00447C2E
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnStickerInfoUpdate));
	}

	// Token: 0x0600EA12 RID: 59922 RVA: 0x00449A4C File Offset: 0x00447C4C
	private MotorcycleDiyPartTabItem InitStickerTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0600EA13 RID: 59923 RVA: 0x00449A54 File Offset: 0x00447C54
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

	// Token: 0x0600EA14 RID: 59924 RVA: 0x00449AB3 File Offset: 0x00447CB3
	private MotorcycleDiyStickerDecoItem CreateStickerItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickSticker)
		};
	}

	// Token: 0x0600EA15 RID: 59925 RVA: 0x00449ACC File Offset: 0x00447CCC
	public void RefreshItemScrollView()
	{
		if (this.StickerScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectStickerPart, true);
		}
	}

	// Token: 0x0600EA16 RID: 59926 RVA: 0x00449AE4 File Offset: 0x00447CE4
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

	// Token: 0x0600EA17 RID: 59927 RVA: 0x00449CB0 File Offset: 0x00447EB0
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

	// Token: 0x0600EA18 RID: 59928 RVA: 0x00449D08 File Offset: 0x00447F08
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

	// Token: 0x0600EA19 RID: 59929 RVA: 0x00449D54 File Offset: 0x00447F54
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

	// Token: 0x0600EA1A RID: 59930 RVA: 0x00449DE4 File Offset: 0x00447FE4
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
		MotorcycleDiyStickerDecoItemData motorcycleDiyStickerDecoItemData = stickerDataList.Find((MotorcycleDiyStickerDecoItemData data) => data.ItemId == selectStickerId);
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

	// Token: 0x0600EA1B RID: 59931 RVA: 0x00449E95 File Offset: 0x00448095
	private void OnStickerInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Sticker, new int?(this.CurrentSelectStickerPart));
		this.RefreshScrollViewByData(this.CurrentSelectStickerPart, false);
	}

	// Token: 0x0600EA1C RID: 59932 RVA: 0x00449EBC File Offset: 0x004480BC
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

	// Token: 0x0600EA1D RID: 59933 RVA: 0x0044A22E File Offset: 0x0044842E
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x0600EA1E RID: 59934 RVA: 0x0044A248 File Offset: 0x00448448
	private void OnBtnOverviewClick()
	{
		List<object> list = new List<object>();
		list.Add(EOutlookType.Sticker);
		list.Add(this.CurrentSelectStickerPart);
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyOverviewView, list, null);
	}

	// Token: 0x0400850D RID: 34061
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x0400850E RID: 34062
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> StickerScrollView;

	// Token: 0x0400850F RID: 34063
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x04008510 RID: 34064
	private List<MotorcycleDiyStickerDecoItemData> CachedStickerDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x04008511 RID: 34065
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008512 RID: 34066
	private int CurrentSelectStickerPart;

	// Token: 0x04008513 RID: 34067
	private int JumpId;

	// Token: 0x02007977 RID: 31095
	[NullableContext(0)]
	private class EMotorStickerScrollViewComponent
	{
		// Token: 0x040275D2 RID: 161234
		public const int TabContent = 0;

		// Token: 0x040275D3 RID: 161235
		public const int TabItem = 1;

		// Token: 0x040275D4 RID: 161236
		public const int LoopScrollView = 2;

		// Token: 0x040275D5 RID: 161237
		public const int SVContent = 3;

		// Token: 0x040275D6 RID: 161238
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x040275D7 RID: 161239
		public const int RightLayout = 5;

		// Token: 0x040275D8 RID: 161240
		public const int TxtStickerName = 6;

		// Token: 0x040275D9 RID: 161241
		public const int LockItem = 7;

		// Token: 0x040275DA RID: 161242
		public const int TxtCurEquip = 8;

		// Token: 0x040275DB RID: 161243
		public const int BtnJump = 9;

		// Token: 0x040275DC RID: 161244
		public const int TipsItem = 10;

		// Token: 0x040275DD RID: 161245
		public const int TxtTipsName = 11;

		// Token: 0x040275DE RID: 161246
		public const int TitleGetItem = 12;

		// Token: 0x040275DF RID: 161247
		public const int TxtJump = 13;

		// Token: 0x040275E0 RID: 161248
		public const int BtnOverview = 14;

		// Token: 0x040275E1 RID: 161249
		public const int MenuItem = 15;

		// Token: 0x040275E2 RID: 161250
		public const int SmallTitleItem = 16;

		// Token: 0x040275E3 RID: 161251
		public const int NormalPanel = 17;

		// Token: 0x040275E4 RID: 161252
		public const int EditPresetPanel = 18;
	}
}
