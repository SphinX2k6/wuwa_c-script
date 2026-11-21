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

// Token: 0x02001785 RID: 6021
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyDecorationTabView : UiTabViewBase, IMotorcycleDiyTabViewRegister
{
	// Token: 0x17001656 RID: 5718
	// (get) Token: 0x0600E9DF RID: 59871 RVA: 0x00448462 File Offset: 0x00446662
	// (set) Token: 0x0600E9E0 RID: 59872 RVA: 0x0044846A File Offset: 0x0044666A
	[Nullable(2)]
	public Action<int> OnTabCameraClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001657 RID: 5719
	// (get) Token: 0x0600E9E1 RID: 59873 RVA: 0x00448473 File Offset: 0x00446673
	// (set) Token: 0x0600E9E2 RID: 59874 RVA: 0x0044847B File Offset: 0x0044667B
	[Nullable(2)]
	public Action<EOutlookType, int, int> OnSelectItemClick { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x0600E9E3 RID: 59875 RVA: 0x00448484 File Offset: 0x00446684
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

	// Token: 0x0600E9E4 RID: 59876 RVA: 0x00448658 File Offset: 0x00446858
	protected override UniTask OnBeforeStartAsync()
	{
		MotorcycleDiyDecorationTabView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleDiyDecorationTabView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E9E5 RID: 59877 RVA: 0x0044869C File Offset: 0x0044689C
	protected override void OnBeforeShow()
	{
		int index = (this.CurrentSelectDecorationPart > 0) ? (this.CurrentSelectDecorationPart - 1) : 0;
		this.PartTabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0600E9E6 RID: 59878 RVA: 0x004486CC File Offset: 0x004468CC
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x0600E9E7 RID: 59879 RVA: 0x004486EA File Offset: 0x004468EA
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MotorDiyInfoUpdate, new Action(this.OnDecorationInfoUpdate));
	}

	// Token: 0x0600E9E8 RID: 59880 RVA: 0x00448708 File Offset: 0x00446908
	private MotorcycleDiyPartTabItem InitDecorationTabItem([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new MotorcycleDiyPartTabItem();
	}

	// Token: 0x0600E9E9 RID: 59881 RVA: 0x00448710 File Offset: 0x00446910
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

	// Token: 0x0600E9EA RID: 59882 RVA: 0x00448759 File Offset: 0x00446959
	private MotorcycleDiyStickerDecoItem CreateDecorationItem()
	{
		return new MotorcycleDiyStickerDecoItem
		{
			OnClickToggleBack = new Action<int, UUIExtendToggle, UUIItem>(this.OnClickDecoration)
		};
	}

	// Token: 0x0600E9EB RID: 59883 RVA: 0x00448772 File Offset: 0x00446972
	public void RefreshItemScrollView()
	{
		if (this.DecorationScrollView != null)
		{
			this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, true);
		}
	}

	// Token: 0x0600E9EC RID: 59884 RVA: 0x0044878C File Offset: 0x0044698C
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

	// Token: 0x0600E9ED RID: 59885 RVA: 0x00448934 File Offset: 0x00446B34
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

	// Token: 0x0600E9EE RID: 59886 RVA: 0x0044898C File Offset: 0x00446B8C
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

	// Token: 0x0600E9EF RID: 59887 RVA: 0x004489D8 File Offset: 0x00446BD8
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

	// Token: 0x0600E9F0 RID: 59888 RVA: 0x00448A7C File Offset: 0x00446C7C
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
		MotorcycleDiyStickerDecoItemData motorcycleDiyStickerDecoItemData = decorationDataList.Find((MotorcycleDiyStickerDecoItemData data) => data.ItemId == selectDecorationId);
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

	// Token: 0x0600E9F1 RID: 59889 RVA: 0x00448B30 File Offset: 0x00446D30
	private void OnDecorationInfoUpdate()
	{
		MotorcycleDiyModel.Instance.CollectRedDotOnViewOpen(EOutlookType.Decoration, null);
		this.RefreshScrollViewByData(this.CurrentSelectDecorationPart, false);
	}

	// Token: 0x0600E9F2 RID: 59890 RVA: 0x00448B60 File Offset: 0x00446D60
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

	// Token: 0x0600E9F3 RID: 59891 RVA: 0x00448EBC File Offset: 0x004470BC
	private void OnBtnJumpClick()
	{
		if (this.JumpId <= 0)
		{
			return;
		}
		SkipTaskManager.RunByConfigId(this.JumpId, null);
	}

	// Token: 0x040084FE RID: 34046
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MotorcycleDiyPartTabItem> PartTabComponent;

	// Token: 0x040084FF RID: 34047
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleDiyStickerDecoItem, MotorcycleDiyStickerDecoItemData> DecorationScrollView;

	// Token: 0x04008500 RID: 34048
	private readonly List<MotorcycleDiyPartTabItemData> PartTabItemDataList = new List<MotorcycleDiyPartTabItemData>();

	// Token: 0x04008501 RID: 34049
	private List<MotorcycleDiyStickerDecoItemData> CachedDecorationDataList = new List<MotorcycleDiyStickerDecoItemData>();

	// Token: 0x04008502 RID: 34050
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04008503 RID: 34051
	private int CurrentSelectDecorationPart;

	// Token: 0x04008504 RID: 34052
	private int JumpId;

	// Token: 0x02007970 RID: 31088
	[NullableContext(0)]
	private class EMotorDecorationScrollViewComponent
	{
		// Token: 0x040275A8 RID: 161192
		public const int TabContent = 0;

		// Token: 0x040275A9 RID: 161193
		public const int TabItem = 1;

		// Token: 0x040275AA RID: 161194
		public const int LoopScrollView = 2;

		// Token: 0x040275AB RID: 161195
		public const int SVContent = 3;

		// Token: 0x040275AC RID: 161196
		public const int TogMotoDiyStickerOrDecoTabItem = 4;

		// Token: 0x040275AD RID: 161197
		public const int RightLayout = 5;

		// Token: 0x040275AE RID: 161198
		public const int TxtDecorationName = 6;

		// Token: 0x040275AF RID: 161199
		public const int LockItem = 7;

		// Token: 0x040275B0 RID: 161200
		public const int TxtCurEquip = 8;

		// Token: 0x040275B1 RID: 161201
		public const int BtnJump = 9;

		// Token: 0x040275B2 RID: 161202
		public const int TipsItem = 10;

		// Token: 0x040275B3 RID: 161203
		public const int TxtTipsName = 11;

		// Token: 0x040275B4 RID: 161204
		public const int TitleGetItem = 12;

		// Token: 0x040275B5 RID: 161205
		public const int TxtJump = 13;

		// Token: 0x040275B6 RID: 161206
		public const int BtnOverview = 14;

		// Token: 0x040275B7 RID: 161207
		public const int MenuItem = 15;

		// Token: 0x040275B8 RID: 161208
		public const int SmallTitleItem = 16;

		// Token: 0x040275B9 RID: 161209
		public const int NormalPanel = 17;

		// Token: 0x040275BA RID: 161210
		public const int EditPresetPanel = 18;
	}
}
