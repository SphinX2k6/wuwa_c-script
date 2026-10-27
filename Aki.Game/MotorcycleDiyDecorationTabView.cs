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

// Token: 0x020022A1 RID: 8865
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDecorationTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x1700161F RID: 5663
	// (get) Token: 0x06011547 RID: 70983 RVA: 0x0043B86A File Offset: 0x00439A6A
	// (set) Token: 0x06011548 RID: 70984 RVA: 0x0043B872 File Offset: 0x00439A72
	[Nullable(2)]
	public Action<int> OnTabCameraClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001620 RID: 5664
	// (get) Token: 0x06011549 RID: 70985 RVA: 0x0043B87B File Offset: 0x00439A7B
	// (set) Token: 0x0601154A RID: 70986 RVA: 0x0043B883 File Offset: 0x00439A83
	[Nullable(2)]
	public Action<EOutlookType, int, int> OnSelectItemClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x0601154B RID: 70987 RVA: 0x0043B88C File Offset: 0x00439A8C
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
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnJumpClick))
		};
	}

	// Token: 0x0601154C RID: 70988 RVA: 0x0043BA60 File Offset: 0x00439C60
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyDecorationTabView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyDecorationTabView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601154D RID: 70989 RVA: 0x0043BAA4 File Offset: 0x00439CA4
	protected override void OnBeforeShow()
	{
		int index = (this.CurrentSelectDecorationPart > 0) ? (this.CurrentSelectDecorationPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0601154E RID: 70990 RVA: 0x0043BAD4 File Offset: 0x00439CD4
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x0601154F RID: 70991 RVA: 0x0043BAF2 File Offset: 0x00439CF2
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x06011550 RID: 70992 RVA: 0x0043BB10 File Offset: 0x00439D10
	private MotorcycleDiyPartTabItem InitDecorationTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x06011551 RID: 70993 RVA: 0x0043BB18 File Offset: 0x00439D18
	private void ToggleCallBack(int index)
	{
		MotorcycleDiyPartTabItemData motorcycleDiyPartTabItemData = this.PartTabItemDataList[index];
		this.CurrentSelectDecorationPart = motorcycleDiyPartTabItemData.PartId;
		this.RefreshScrollViewByData(motorcycleDiyPartTabItemData.PartId, true);
		Action<int> onTabCameraClick = this.OnTabCameraClick;
		if (onTabCameraClick == null)
		{
			return;
		}
		onTabCameraClick(this.CurrentSelectDecorationPart);
	}

	// Token: 0x06011552 RID: 70994 RVA: 0x0043BB61 File Offset: 0x00439D61
	private MotorcycleDiyStickerDecoItem CreateDecorationItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickDecoration)
		};
	}

	// Token: 0x06011553 RID: 70995 RVA: 0x0043BB7A File Offset: 0x00439D7A
	public void RefreshItemScrollView()
	{
		if (this.DecorationScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, true);
		}
	}

	// Token: 0x06011554 RID: 70996 RVA: 0x0043BB94 File Offset: 0x00439D94
	private List<MotorcycleDiyStickerDecoItemData> GetDecorationItemDataList(int partId)
	{
		List<MotorcycleDiyStickerDecoItemData> list = new List<MotorcycleDiyStickerDecoItemData>();
		list.Add(new MotorcycleDiyStickerDecoItemData
		{
			Part = partId
		});
		int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedDecorationId(partId));
		if (num != null && num.Value > 0)
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num.Value);
			list.Add(new MotorcycleDiyStickerDecoItemData
			{
				Part = partId,
				ItemId = num.Value,
				QualityId = ((motorDecorationConfig != null) ? motorDecorationConfig.Value.QualityId : 0),
				SortIndex = ((motorDecorationConfig != null) ? motorDecorationConfig.Value.SortIndex : 0)
			});
		}
		foreach (int num2 in MotorcycleDiyModel.Instance.GetCanUseDecorationsIdsInRegion())
		{
			MotorDecorations? motorDecorationConfig2 = MotorDiyConfig.Instance.GetMotorDecorationConfig(num2);
			if (motorDecorationConfig2 != null && motorDecorationConfig2.Value.PartId == partId)
			{
				EOutLookState decorationState = MotorcycleDiyModel.Instance.GetDecorationState(num2);
				if (decorationState != EOutLookState.IsHide && decorationState != EOutLookState.IsEquipped)
				{
					list.Add(new MotorcycleDiyStickerDecoItemData
					{
						Part = partId,
						ItemId = num2,
						QualityId = motorDecorationConfig2.Value.QualityId,
						SortIndex = motorDecorationConfig2.Value.SortIndex
					});
				}
			}
		}
		return list;
	}

	// Token: 0x06011555 RID: 70997 RVA: 0x0043BD3C File Offset: 0x00439F3C
	private int GetDecorationSortPriority(MotorcycleDiyStickerDecoItemData data)
	{
		if (data.ItemId == 0)
		{
			return 0;
		}
		EOutLookState decorationState = MotorcycleDiyModel.Instance.GetDecorationState(data.ItemId);
		if (decorationState == EOutLookState.IsEquipped)
		{
			return 1;
		}
		if (MotorcycleDiyModel.Instance.CheckRedDotInViewOpenCache(data.ItemId))
		{
			return 2;
		}
		if (decorationState == EOutLookState.CanEquipped)
		{
			return 3;
		}
		if (decorationState == EOutLookState.IsLock)
		{
			return 4;
		}
		if (decorationState == EOutLookState.IsBan)
		{
			return 5;
		}
		return 6;
	}

	// Token: 0x06011556 RID: 70998 RVA: 0x0043BD94 File Offset: 0x00439F94
	private int SortDecorationItemFunc(MotorcycleDiyStickerDecoItemData dataA, MotorcycleDiyStickerDecoItemData dataB)
	{
		int decorationSortPriority = this.GetDecorationSortPriority(dataA);
		int decorationSortPriority2 = this.GetDecorationSortPriority(dataB);
		if (decorationSortPriority != decorationSortPriority2)
		{
			return decorationSortPriority - decorationSortPriority2;
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

	// Token: 0x06011557 RID: 70999 RVA: 0x0043BDE0 File Offset: 0x00439FE0
	private void RefreshScrollViewByData(int partId, bool isNeedRefresh)
	{
		if (isNeedRefresh)
		{
			MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Decoration, new int?(partId));
			List<MotorcycleDiyStickerDecoItemData> decorationDataList = this.GetDecorationItemDataList(partId);
			decorationDataList.Sort(new Comparison<MotorcycleDiyStickerDecoItemData>(this.SortDecorationItemFunc));
			this.CachedDecorationDataList = decorationDataList;
			this.DecorationScrollView.RefreshByData(decorationDataList, true, delegate
			{
				this.AutoSelectGridByDataList(partId, decorationDataList);
			}, false);
			return;
		}
		this.DecorationScrollView.RefreshByData(this.CachedDecorationDataList, true, null, false);
	}

	// Token: 0x06011558 RID: 71000 RVA: 0x0043BE84 File Offset: 0x0043A084
	private void AutoSelectGridByDataList(int decorationPart, List<MotorcycleDiyStickerDecoItemData> decorationDataList)
	{
		int gridIndex = 0;
		int selectDecorationId = 0;
		int selectedDecorationId = MotorcycleDiyModel.Instance.GetSelectedDecorationId(decorationPart);
		if (selectedDecorationId != 0)
		{
			selectDecorationId = selectedDecorationId;
		}
		else
		{
			int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedDecorationId(decorationPart));
			selectDecorationId = ((num != null) ? num.Value : 0);
		}
		MotorcycleDiyStickerDecoItemData motorcycleDiyStickerDecoItemData = decorationDataList.FirstOrDefault((MotorcycleDiyStickerDecoItemData data) => data.ItemId == selectDecorationId);
		if (motorcycleDiyStickerDecoItemData != null)
		{
			gridIndex = decorationDataList.IndexOf(motorcycleDiyStickerDecoItemData);
		}
		if (!this.DecorationScrollView.IsGridDisplaying(gridIndex))
		{
			this.DecorationScrollView.ScrollToGridIndex(gridIndex, false);
		}
		this.DecorationScrollView.DeselectCurrentGridProxy(false);
		this.DecorationScrollView.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06011559 RID: 71001 RVA: 0x0043BF38 File Offset: 0x0043A138
	private void OnDecorationInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Decoration, null);
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
	}

	// Token: 0x0601155A RID: 71002 RVA: 0x0043BF68 File Offset: 0x0043A168
	private void OnClickDecoration(int decorationId, UUIExtendToggle toggle, UUIItem newItem)
	{
		EOutLookState decorationState = MotorcycleDiyModel.Instance.GetDecorationState(decorationId);
		if (decorationState == EOutLookState.IsBan)
		{
			toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			ValueTuple<string, string>? banTips = MotorcycleDiyModel.Instance.GetBanTips(EOutlookType.Decoration, decorationId);
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
		if (decorationId == 0)
		{
			MotorcycleUiModelUtil.Instance.SetEmptyDecoration(this.CurrentSelectDecorationPart);
		}
		else
		{
			MotorcycleUiModelUtil.Instance.AddDecoration(decorationId, null);
		}
		bool flag = MotorcycleDiyModel.Instance.IsEquipDefaultDecoration(this.CurrentSelectDecorationPart);
		bool flag2 = decorationId == 0 && !flag;
		MotorcycleDiyModel.Instance.SetSelectDecorationInfo(this.CurrentSelectDecorationPart, decorationId);
		if (decorationState == EOutLookState.CanEquipped || flag2)
		{
			List<int> selectedDecorationIdList = MotorcycleDiyModel.Instance.GetSelectedDecorationIdList(true);
			MotorcycleDiyController.Instance.EquipMotorDecorationRequest(selectedDecorationIdList, null);
		}
		Action<EOutlookType, int, int> onSelectItemClick = this.OnSelectItemClick;
		if (onSelectItemClick != null)
		{
			onSelectItemClick(EOutlookType.Decoration, this.CurrentSelectDecorationPart, decorationId);
		}
		EventSystem.Instance.Emit(EEventName.MotorDiyInfoRedDotUpdate);
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
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
		if (decorationId <= 0)
		{
			string stringConfig = ConfigCommonParamById.GetStringConfig("MotorEmptyDecorationName");
			text4.SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(text3, stringConfig, Array.Empty<object>());
			return;
		}
		text4.SetUIActive(true);
		MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(decorationId);
		if (motorDecorationConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text4, motorDecorationConfig.Value.SubTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text3, motorDecorationConfig.Value.Title, Array.Empty<object>());
		base.GetItem(7).SetUIActive(decorationState == EOutLookState.IsLock);
		int[] itemAccessArray = motorDecorationConfig.Value.GetItemAccessArray();
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
		button.RootUIComp.Get().SetUIActive(skipName != ESkipName.NoSkip && decorationState == EOutLookState.IsLock);
		item3.SetUIActive(decorationState == EOutLookState.IsLock);
		item2.SetUIActive(skipName == ESkipName.NoSkip && decorationState == EOutLookState.IsLock);
		LguiUtil.Instance.SetLocalTextNew(text, accessPathConfig.Value.Description, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(text2, accessPathConfig.Value.Description, Array.Empty<object>());
	}

	// Token: 0x0601155B RID: 71003 RVA: 0x0043C2C4 File Offset: 0x0043A4C4
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x040083C0 RID: 33728
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x040083C1 RID: 33729
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> DecorationScrollView;

	// Token: 0x040083C2 RID: 33730
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x040083C3 RID: 33731
	private List<MotorcycleDiyStickerDecoItemData> CachedDecorationDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x040083C4 RID: 33732
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x040083C5 RID: 33733
	private int CurrentSelectDecorationPart;

	// Token: 0x040083C6 RID: 33734
	private int JumpId;

	// Token: 0x020087E7 RID: 34791
	[NullableContext(0)]
	private class EMotorDecorationScrollViewComponent
	{
		// Token: 0x0402C29C RID: 180892
		public const int TabContent = 0;

		// Token: 0x0402C29D RID: 180893
		public const int TabItem = 1;

		// Token: 0x0402C29E RID: 180894
		public const int LoopScrollView = 2;

		// Token: 0x0402C29F RID: 180895
		public const int SVContent = 3;

		// Token: 0x0402C2A0 RID: 180896
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x0402C2A1 RID: 180897
		public const int RightLayout = 5;

		// Token: 0x0402C2A2 RID: 180898
		public const int TxtDecorationName = 6;

		// Token: 0x0402C2A3 RID: 180899
		public const int LockItem = 7;

		// Token: 0x0402C2A4 RID: 180900
		public const int TxtCurEquip = 8;

		// Token: 0x0402C2A5 RID: 180901
		public const int BtnJump = 9;

		// Token: 0x0402C2A6 RID: 180902
		public const int TipsItem = 10;

		// Token: 0x0402C2A7 RID: 180903
		public const int TxtTipsName = 11;

		// Token: 0x0402C2A8 RID: 180904
		public const int TitleGetItem = 12;

		// Token: 0x0402C2A9 RID: 180905
		public const int TxtJump = 13;

		// Token: 0x0402C2AA RID: 180906
		public const int BtnOverview = 14;

		// Token: 0x0402C2AB RID: 180907
		public const int MenuItem = 15;

		// Token: 0x0402C2AC RID: 180908
		public const int SmallTitleItem = 16;

		// Token: 0x0402C2AD RID: 180909
		public const int NormalPanel = 17;

		// Token: 0x0402C2AE RID: 180910
		public const int EditPresetPanel = 18;
	}
}
