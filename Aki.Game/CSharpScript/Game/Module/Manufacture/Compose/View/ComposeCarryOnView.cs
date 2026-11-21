using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.Manufacture.Common.Item;
using CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004643 RID: 17987
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeCarryOnView : UiViewBase
	{
		// Token: 0x0602D35D RID: 185181 RVA: 0x00CA44D8 File Offset: 0x00CA26D8
		public ComposeCarryOnView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D35E RID: 185182 RVA: 0x00CA4540 File Offset: 0x00CA2740
		protected unsafe override void OnRegisterComponent()
		{
			int num = 46;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(42, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickComposeLevelBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(24, new Action(this.OnClickConfirmBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(27, new Action(this.OnClickLeftPopItemCloseBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D35F RID: 185183 RVA: 0x00CA4C00 File Offset: 0x00CA2E00
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.OnCookResponse));
			EventSystem.Instance.Add(EEventName.ComposeFail, new Action(this.OnCookResponse));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<EComposeListType, int>(EEventName.ComposeSwitchType, new Action<EComposeListType, int>(this.ComposeSwitchType));
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(this.SwitchComposeLevelShow));
			EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			this.RefreshTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnSecondTimerRefresh), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602D360 RID: 185184 RVA: 0x00CA4CDC File Offset: 0x00CA2EDC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.OnCookResponse));
			EventSystem.Instance.Remove(EEventName.ComposeFail, new Action(this.OnCookResponse));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.ComposeSwitchType, new Action<EComposeListType, int>(this.ComposeSwitchType));
			EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(this.SwitchComposeLevelShow));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
			if (this.RefreshTimer != null && TimerSystem.Instance.Has(this.RefreshTimer))
			{
				TimerSystem.Instance.Remove(this.RefreshTimer);
				this.RefreshTimer = null;
			}
		}

		// Token: 0x0602D361 RID: 185185 RVA: 0x00CA4DC0 File Offset: 0x00CA2FC0
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeCarryOnView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeCarryOnView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D362 RID: 185186 RVA: 0x00CA4E03 File Offset: 0x00CA3003
		protected override void OnStart()
		{
			CommonManager.Instance.SetCurrentSystem(ESystemType.ComposeSystem);
		}

		// Token: 0x0602D363 RID: 185187 RVA: 0x00CA4E10 File Offset: 0x00CA3010
		protected override void OnBeforeShow()
		{
			ComposeViewOpenData composeViewOpenData = this.OpenParam as ComposeViewOpenData;
			this.TipsItemData = ((composeViewOpenData != null) ? composeViewOpenData.SelectData : null);
			this.SkipSourceView = ((composeViewOpenData != null) ? composeViewOpenData.SkipSourceView : null);
			ISelectedData tipsItemData = this.TipsItemData;
			this.TargetItem = ((tipsItemData != null) ? tipsItemData.ItemId : 0);
			this.ShowComposeMainView((composeViewOpenData != null) ? this.TabList.IndexOf(composeViewOpenData.Type) : 0);
			this.TargetItem = 0;
		}

		// Token: 0x0602D364 RID: 185188 RVA: 0x00CA4E91 File Offset: 0x00CA3091
		protected override void OnBeforeDestroy()
		{
			ComposeModel.Instance.CurrentComposeListType = EComposeListType.Purification;
		}

		// Token: 0x0602D365 RID: 185189 RVA: 0x00CA4EA0 File Offset: 0x00CA30A0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length < 1)
			{
				return null;
			}
			int item = int.Parse(configParams[0]);
			int num = this.TabList.IndexOf((EComposeListType)item);
			if (num < 0)
			{
				return null;
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			UUIItem uuiitem;
			if (tabComponent == null)
			{
				uuiitem = null;
			}
			else
			{
				CommonTabItem tabItemByIndex = tabComponent.GetTabItemByIndex(num);
				uuiitem = ((tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem2,
				uuiitem2
			};
		}

		// Token: 0x0602D366 RID: 185190 RVA: 0x00CA4F04 File Offset: 0x00CA3104
		private void SetSum(int sum)
		{
			this.Count = sum;
			this.RefreshMaterialNeedNum();
			bool flag = ComposeModel.Instance.CurrentComposeListType == EComposeListType.Collect;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(30), flag ? "GatherCraft_Quantity_Text" : "Text_ItemSelectSynthesisQuantityTip_text", new <>z__ReadOnlySingleElementList<object>(this.Count));
			if (this.ItemData != null && this.ItemData.MainType == EComposeListType.ReagentProduction)
			{
				int maxCreateCount = ComposeController.Instance.GetMaxCreateCount(this.ItemData.ConfigId, this.ItemData);
				this.NumberSelect.SetAddButtonInteractive(sum < maxCreateCount);
				this.NumberSelect.SetReduceButtonInteractive(sum > 1);
				this.RefreshProficiency(true);
			}
		}

		// Token: 0x0602D367 RID: 185191 RVA: 0x00CA4FB4 File Offset: 0x00CA31B4
		private bool CanToggleChange(int arg1, bool? arg2)
		{
			if (this.NoCircleExhibitionView.MovingState())
			{
				return false;
			}
			if (Info.Instance.IsInGamepad())
			{
				return true;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("panel_interval_time");
			return this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)intConfig.Value;
		}

		// Token: 0x0602D368 RID: 185192 RVA: 0x00CA5018 File Offset: 0x00CA3218
		private void RefreshProficiency(bool isVisible)
		{
			if (!isVisible)
			{
				base.GetText(14).SetUIActive(false);
				return;
			}
			base.GetText(14).SetUIActive(true);
			IReagentProductionData reagentProductionData = this.ItemData as IReagentProductionData;
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(reagentProductionData.ConfigId);
			int proficiency = synthesisFormulaById.Value.Proficiency;
			int maxProficiencyCount = synthesisFormulaById.Value.MaxProficiencyCount;
			this.SetExpNum(reagentProductionData.ComposeCount, proficiency, maxProficiencyCount, this.Count);
		}

		// Token: 0x0602D369 RID: 185193 RVA: 0x00CA5098 File Offset: 0x00CA3298
		private void RefreshMaterialNeedNum()
		{
			this.RefreshCost(this.HasCoin, this.SingleNeedCoinCount * this.Count);
			if (this.ItemData != null && ComposeModel.Instance.IsInPurificationList())
			{
				List<IComposeItemData> list = ComposeModel.Instance.CalculateNeedComposeMaterialList(this.ItemData.ConfigId, this.Count);
				List<SingleItemInfo> list2 = new List<SingleItemInfo>(list.Count);
				foreach (IComposeItemData composeItemData in list)
				{
					list2.Add(new SingleItemInfo
					{
						ItemId = composeItemData.ItemId,
						ItemNum = composeItemData.RequiredNum
					});
				}
				ComposeModel.Instance.SetCurrentComposeMaterialList(list2);
				List<IComposeItemData> uiList = new List<IComposeItemData>(list.Count);
				for (int i = list.Count - 1; i >= 0; i--)
				{
					uiList.Add(list[i]);
				}
				List<ISingleItemInfo> list3 = new List<ISingleItemInfo>(uiList.Count);
				foreach (IComposeItemData composeItemData2 in uiList)
				{
					list3.Add(new ISingleItemInfo
					{
						Proto_ItemId = composeItemData2.ItemId,
						Proto_ItemNum = composeItemData2.RequiredNum,
						Proto_IsUnlock = true
					});
				}
				GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
				if (materialScrollView == null)
				{
					return;
				}
				materialScrollView.RefreshByData(list3, delegate
				{
					GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView3 = this.MaterialScrollView;
					List<ManufactureMaterialItem> list5 = (materialScrollView3 != null) ? materialScrollView3.GetScrollItemList() : null;
					if (list5 != null)
					{
						for (int j = 0; j < list5.Count; j++)
						{
							list5[j].SetNeedNum(uiList[j].RequiredNum);
						}
					}
				}, false);
				return;
			}
			else
			{
				GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView2 = this.MaterialScrollView;
				List<ManufactureMaterialItem> list4 = (materialScrollView2 != null) ? materialScrollView2.GetScrollItemList() : null;
				if (list4 == null)
				{
					return;
				}
				foreach (ManufactureMaterialItem manufactureMaterialItem in list4)
				{
					manufactureMaterialItem.SetUiActive(true);
					manufactureMaterialItem.SetTimes(this.Count);
				}
				return;
			}
		}

		// Token: 0x0602D36A RID: 185194 RVA: 0x00CA52B0 File Offset: 0x00CA34B0
		private void RefreshCost(bool hasCoin, int count)
		{
			if (!hasCoin)
			{
				UUITexture texture = base.GetTexture(32);
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				base.GetText(31).SetUIActive(false);
				return;
			}
			UUITexture texture2 = base.GetTexture(32);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			base.GetText(31).SetUIActive(true);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(ComposeController.Instance.ComposeCoinId, 0);
			ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(ComposeController.Instance.ComposeCoinId);
			if (itemCountByConfigId < count)
			{
				base.GetText(31).SetText(StringUtils.Format("<color=#c25757>{0}</color>", new string[]
				{
					count.ToString()
				}), true);
			}
			else
			{
				base.GetText(31).SetText(count.ToString(), true);
			}
			base.SetTextureByPath(config.Value.IconSmall, base.GetTexture(32), null, null);
		}

		// Token: 0x0602D36B RID: 185195 RVA: 0x00CA5398 File Offset: 0x00CA3598
		private unsafe void SetExpNum(int count, int single, int sum, int times)
		{
			int num = single * sum;
			int num2 = count * single;
			int num3 = num - num2;
			string text = StringUtils.Format(TextConfig.Instance.GetTextById("CumulativeProficiency"), new string[]
			{
				num2.ToString(),
				num.ToString()
			});
			if (num3 > 0)
			{
				int val = Math.Min(num3, single * times);
				string textById = TextConfig.Instance.GetTextById("AddProficiency");
				string[] array = new string[1];
				int num4 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Math.Min(val, num3));
				array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
				string text2 = StringUtils.Format(textById, array);
				<>y__InlineArray5<string> <>y__InlineArray = default(<>y__InlineArray5<string>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 0) = text2;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 1) = " ";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 2) = "(";
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 3) = text;
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray, 4) = ")";
				string newText = string.Concat(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<string>, string>(<>y__InlineArray, 5));
				base.GetText(14).SetText(newText, true);
				return;
			}
			string text3 = StringUtils.Format(TextConfig.Instance.GetTextById("AddProficiency"), new string[]
			{
				""
			});
			<>y__InlineArray5<string> <>y__InlineArray2 = default(<>y__InlineArray5<string>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray2, 0) = text3;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray2, 1) = " ";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray2, 2) = "(";
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray2, 3) = text;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<string>, string>(ref <>y__InlineArray2, 4) = ")";
			string newText2 = string.Concat(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<string>, string>(<>y__InlineArray2, 5));
			base.GetText(14).SetText(newText2, true);
		}

		// Token: 0x0602D36C RID: 185196 RVA: 0x00CA5530 File Offset: 0x00CA3730
		private ManufactureMaterialItem OnMaterialItemCreate()
		{
			ManufactureMaterialItem manufactureMaterialItem = new ManufactureMaterialItem();
			manufactureMaterialItem.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			manufactureMaterialItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = callbackParameter.Data as ISingleItemInfo;
				if (this.ItemData.MainType == EComposeListType.Exchange)
				{
					this.OpenLeftPopView();
					return;
				}
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null, false);
			});
			manufactureMaterialItem.BindEmptySlotButtonCallback(delegate(MediumItemGridButtonCallback _)
			{
				this.OpenLeftPopView();
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0602D36D RID: 185197 RVA: 0x00CA558B File Offset: 0x00CA378B
		private ComposeExchangeItem OnExchangeMaterialItemCreate()
		{
			ComposeExchangeItem composeExchangeItem = new ComposeExchangeItem();
			composeExchangeItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
			{
				ISingleItemInfo singleItemInfo = callbackParameter.Data as ISingleItemInfo;
				UUIExtendToggle currentSelectExchangeScrollToggle = this.CurrentSelectExchangeScrollToggle;
				if (currentSelectExchangeScrollToggle != null)
				{
					currentSelectExchangeScrollToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
				this.CurrentSelectExchangeScrollToggle = callbackParameter.MediumItemGrid.GetItemGridExtendToggle();
				int exchangeCountByTargetId = ComposeModel.Instance.GetExchangeCountByTargetId(this.ItemData.ConfigId);
				if (singleItemInfo.Proto_ItemNum < exchangeCountByTargetId)
				{
					ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null, false);
					return;
				}
				this.CurrentSelectExchangeMaterialItem = singleItemInfo.Proto_ItemId;
				this.RefreshExchangeMaterialBySelect(null);
			});
			return composeExchangeItem;
		}

		// Token: 0x0602D36E RID: 185198 RVA: 0x00CA55A4 File Offset: 0x00CA37A4
		private void OnFilterSortRefresh(List<IBaseItemData> list, bool arg1, EFilterSortType arg2)
		{
			List<IBaseItemData> list2 = new List<IBaseItemData>(list.Count);
			foreach (IBaseItemData baseItemData in list)
			{
				if (baseItemData.ExistStartTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(baseItemData.ExistStartTime, baseItemData.ExistEndTime))
				{
					list2.Add(baseItemData);
				}
			}
			this.SelectedItemId = 0;
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				this.ReagentProductionDataList = list2.ConvertAll<IReagentProductionData>(([Nullable(1)] IBaseItemData data) => (IReagentProductionData)data);
				break;
			case EComposeListType.Structure:
				this.StructureDataList = list2.ConvertAll<IStructureData>(([Nullable(1)] IBaseItemData data) => (IStructureData)data);
				break;
			case EComposeListType.Purification:
				this.PurificationDataList = list2.ConvertAll<IPurificationData>(([Nullable(1)] IBaseItemData data) => (IPurificationData)data);
				break;
			case EComposeListType.Exchange:
				this.ExchangeDataList = list2.ConvertAll<IExchangeData>(([Nullable(1)] IBaseItemData data) => (IExchangeData)data);
				break;
			case EComposeListType.Collect:
				this.CollectDataList = list2.ConvertAll<ICollectData>(([Nullable(1)] IBaseItemData data) => (ICollectData)data);
				break;
			}
			this.ComposeScrollPanel.DeselectCurrentGridProxy(false);
			this.RefreshItemScrollView();
			if (list2.Count == 0)
			{
				return;
			}
			this.SetSelectedComposeItem(true);
		}

		// Token: 0x0602D36F RID: 185199 RVA: 0x00CA5764 File Offset: 0x00CA3964
		private void RefreshItemScrollView()
		{
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				this.ComposeScrollPanel.RefreshByData(this.ReagentProductionDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IReagentProductionData v) => v), true);
				return;
			case EComposeListType.Structure:
				this.ComposeScrollPanel.RefreshByData(this.StructureDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IStructureData v) => v), true);
				return;
			case EComposeListType.Purification:
				this.ComposeScrollPanel.RefreshByData(this.PurificationDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IPurificationData v) => v), true);
				return;
			case EComposeListType.Exchange:
				this.ComposeScrollPanel.RefreshByExchangeData(this.ExchangeDataList, true, true);
				return;
			case EComposeListType.Collect:
				this.ComposeScrollPanel.RefreshByData(this.CollectDataList.ConvertAll<IBaseItemData>(([Nullable(1)] ICollectData v) => v), true);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D370 RID: 185200 RVA: 0x00CA5888 File Offset: 0x00CA3A88
		private void ShowComposeMainView(int selectNumber = 0)
		{
			if (selectNumber == 0)
			{
				EFilterSortGroupId groupId = EFilterSortGroupId.PurificationList;
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(groupId, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId = this.SortComponent.GetUniqueIdByGroupId(groupId);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId);
				this.FilterComponent.SetActive(true);
				this.FilterComponent.UpdateData(groupId, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId2 = this.FilterComponent.GetUniqueIdByGroupId(groupId);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId2);
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SelectToggleByIndex(selectNumber, true);
			}
			this.OnShowRedDot();
			this.SwitchComposeLevelShow();
		}

		// Token: 0x0602D371 RID: 185201 RVA: 0x00CA5931 File Offset: 0x00CA3B31
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemList()
		{
			return this.GetItemListByType(ComposeModel.Instance.CurrentComposeListType);
		}

		// Token: 0x0602D372 RID: 185202 RVA: 0x00CA5944 File Offset: 0x00CA3B44
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemListByType(EComposeListType type)
		{
			List<IBaseItemData> result;
			switch (type)
			{
			case EComposeListType.ReagentProduction:
			{
				List<IReagentProductionData> reagentProductionDataList = ComposeModel.Instance.GetReagentProductionDataList();
				List<IBaseItemData> list;
				if (reagentProductionDataList == null)
				{
					list = null;
				}
				else
				{
					list = reagentProductionDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IReagentProductionData v) => v);
				}
				result = list;
				break;
			}
			case EComposeListType.Structure:
			{
				List<IStructureData> structureDataList = ComposeModel.Instance.GetStructureDataList();
				List<IBaseItemData> list2;
				if (structureDataList == null)
				{
					list2 = null;
				}
				else
				{
					list2 = structureDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IStructureData v) => v);
				}
				result = list2;
				break;
			}
			case EComposeListType.Purification:
			{
				List<IPurificationData> purificationDataList = ComposeModel.Instance.GetPurificationDataList();
				List<IBaseItemData> list3;
				if (purificationDataList == null)
				{
					list3 = null;
				}
				else
				{
					list3 = purificationDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IPurificationData v) => v);
				}
				result = list3;
				break;
			}
			case EComposeListType.Exchange:
			{
				List<IExchangeData> exchangeDataList = ComposeModel.Instance.GetExchangeDataList();
				List<IBaseItemData> list4;
				if (exchangeDataList == null)
				{
					list4 = null;
				}
				else
				{
					list4 = exchangeDataList.ConvertAll<IBaseItemData>(([Nullable(1)] IExchangeData v) => v);
				}
				result = list4;
				break;
			}
			case EComposeListType.Collect:
			{
				List<ICollectData> collectDataList = ComposeModel.Instance.GetCollectDataList();
				List<IBaseItemData> list5;
				if (collectDataList == null)
				{
					list5 = null;
				}
				else
				{
					list5 = collectDataList.ConvertAll<IBaseItemData>(([Nullable(1)] ICollectData v) => v);
				}
				result = list5;
				break;
			}
			default:
				return null;
			}
			return result;
		}

		// Token: 0x0602D373 RID: 185203 RVA: 0x00CA5A98 File Offset: 0x00CA3C98
		private void SwitchComposeLevelShow()
		{
			(base.GetButton(4).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction);
			int? composeMaxLevel = CommonManager.Instance.GetComposeMaxLevel();
			int? currentRewardLevel = CommonManager.Instance.GetCurrentRewardLevel();
			this.StartLevelComponent.ShowLevel(currentRewardLevel.Value, composeMaxLevel.Value);
			this.SetComposeLevelSprite();
		}

		// Token: 0x0602D374 RID: 185204 RVA: 0x00CA5B02 File Offset: 0x00CA3D02
		private void OnCommonItemCountAnyChange(int i, int i1)
		{
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.Exchange)
			{
				return;
			}
			this.TargetItem = this.SelectedItemId;
			this.SwitchComposeLevelShow();
			this.SwitchComposeItemScroll();
			this.TargetItem = 0;
		}

		// Token: 0x0602D375 RID: 185205 RVA: 0x00CA5B34 File Offset: 0x00CA3D34
		private void SetComposeLevelSprite()
		{
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ReagentProductionLevel");
				this.SetSpriteByPath(resourcePath, base.GetSprite(35), false, null, null);
			}
		}

		// Token: 0x0602D376 RID: 185206 RVA: 0x00CA5B78 File Offset: 0x00CA3D78
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(34), null, 0);
		}

		// Token: 0x0602D377 RID: 185207 RVA: 0x00CA5B90 File Offset: 0x00CA3D90
		private void RefreshLimitTime()
		{
			if (this.ItemData.ExistEndTime <= 0.0 && this.ItemData.TotalMakeCountInLimitTime <= 0)
			{
				UUIText text = base.GetText(23);
				if (text == null)
				{
					return;
				}
				text.SetUIActive(false);
				return;
			}
			else
			{
				this.BottomTextNeedShow = true;
				UUIText text2 = base.GetText(23);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				if (this.ItemData.IsLimitForever)
				{
					global::CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat(this.ItemData.ExistEndTime - TimeUtil.Instance.GetServerTime());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(23), "RemainingTime", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat));
					return;
				}
				string refreshLimitTime = ComposeModel.Instance.GetRefreshLimitTime();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(23), "RefreshTime", new <>z__ReadOnlySingleElementList<object>(refreshLimitTime));
				return;
			}
		}

		// Token: 0x0602D378 RID: 185208 RVA: 0x00CA5C64 File Offset: 0x00CA3E64
		private void RefreshMaterial()
		{
			this.Count = 1;
			int maxCreateCount = ComposeController.Instance.GetMaxCreateCount(this.ItemData.ConfigId, this.ItemData);
			this.NumberSelect.ResetLimitMaxValue();
			this.NumberSelect.Refresh(maxCreateCount);
			this.NumberSelect.SetMaxBtnShowState(maxCreateCount > 1);
			if (this.TipsItemData != null)
			{
				SynthesisFormula? synthesisFormula;
				int? num = (ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId) != null) ? new int?(synthesisFormula.GetValueOrDefault().ItemId) : null;
				int itemId = this.TipsItemData.ItemId;
				if (num.GetValueOrDefault() == itemId & num != null)
				{
					int num2 = this.TipsItemData.Count - this.TipsItemData.SelectedCount;
					if (num2 > 0)
					{
						if (num2 <= maxCreateCount)
						{
							this.NumberSelect.ChangeValue(num2, true);
						}
						else if (maxCreateCount >= 1)
						{
							this.NumberSelect.ChangeValue(maxCreateCount, true);
						}
					}
				}
			}
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(this.Count > 1);
			this.NumberSelect.SetUiActive(this.ItemData.IsUnlock > 0);
			base.GetText(30).SetUIActive(this.ItemData.IsUnlock > 0);
			if (this.ItemData.IsUnlock > 0)
			{
				this.UnlockMaterialComponent.SetUiActive(false);
				this.MaterialScrollView.SetActive(true);
				List<ISingleItemInfo> list = ComposeModel.Instance.GetComposeMaterialList(this.ItemData.ConfigId);
				ValueTuple<bool, int, List<ISingleItemInfo>> valueTuple = this.FilterMaterialList(list);
				bool item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				List<ISingleItemInfo> item3 = valueTuple.Item3;
				this.HasCoin = item;
				this.SingleNeedCoinCount = item2;
				list = item3;
				if (ComposeModel.Instance.IsInPurificationList())
				{
					ComposeModel.Instance.SetCurrentComposeMaterialList(new List<SingleItemInfo>());
					list.Reverse();
					foreach (ISingleItemInfo singleItemInfo in list)
					{
						ComposeModel.Instance.GetCurrentComposeMaterialList().Add(new SingleItemInfo
						{
							ItemId = singleItemInfo.Proto_ItemId,
							ItemNum = singleItemInfo.Proto_ItemNum
						});
					}
				}
				this.MaterialScrollView.RefreshByData(list, new Action(this.RefreshMaterialNeedNum), false);
				return;
			}
			this.UnlockMaterialComponent.SetUiActive(true);
			this.MaterialScrollView.SetActive(false);
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId);
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(synthesisFormulaById.Value.FormulaItemId);
			if (itemConfig == null)
			{
				return;
			}
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = synthesisFormulaById.Value.FormulaItemId,
				ItemConfigId = new int?(synthesisFormulaById.Value.FormulaItemId),
				BottomTextId = itemConfig.Value.Name,
				IsProhibit = new bool?(true),
				IsOmitBottomText = new bool?(true)
			};
			this.UnlockMaterialComponent.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x0602D379 RID: 185209 RVA: 0x00CA5FA4 File Offset: 0x00CA41A4
		private void RefreshExchangeMaterial()
		{
			this.Count = 1;
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetReduceButtonInteractive(true);
			this.NumberSelect.SetUiActive(false);
			this.NumberSelect.SetMaxBtnShowState(true);
			base.GetText(30).SetUIActive(true);
			this.UnlockMaterialComponent.SetUiActive(false);
			this.MaterialScrollView.SetActive(true);
			this.HasCoin = false;
			this.SingleNeedCoinCount = 0;
			this.CurrentSelectExchangeMaterialItem = 0;
			GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
			if (materialScrollView != null)
			{
				materialScrollView.RefreshByData(new <>z__ReadOnlySingleElementList<ISingleItemInfo>(new ISingleItemInfo
				{
					Proto_ItemId = 0,
					Proto_ItemNum = 0,
					Proto_IsUnlock = true,
					IsEmpty = new bool?(true)
				}), null, false);
			}
			this.NumberSelect.Refresh(0);
		}

		// Token: 0x0602D37A RID: 185210 RVA: 0x00CA6070 File Offset: 0x00CA4270
		[NullableContext(2)]
		private void RefreshExchangeMaterialBySelect(Action callback = null)
		{
			ComposeCarryOnView.<>c__DisplayClass66_0 CS$<>8__locals1 = new ComposeCarryOnView.<>c__DisplayClass66_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.callback = callback;
			int exchangeCountByTargetId = ComposeModel.Instance.GetExchangeCountByTargetId(this.ItemData.ConfigId);
			CS$<>8__locals1.<RefreshExchangeMaterialBySelect>g__RefreshDataAsync|0(exchangeCountByTargetId).Forget();
			NumberSelectComponent numberSelect = this.NumberSelect;
			if (numberSelect != null)
			{
				numberSelect.SetUiActive(true);
			}
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CurrentSelectExchangeMaterialItem, 0);
			NumberSelectComponent numberSelect2 = this.NumberSelect;
			if (numberSelect2 != null)
			{
				numberSelect2.Refresh(itemCountByConfigId / exchangeCountByTargetId);
			}
			UUIText text = base.GetText(43);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0602D37B RID: 185211 RVA: 0x00CA60FC File Offset: 0x00CA42FC
		[return: TupleElementNames(new string[]
		{
			"hasCoin",
			"coinCount",
			"list"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<bool, int, List<ISingleItemInfo>> FilterMaterialList(List<ISingleItemInfo> list)
		{
			bool item = false;
			int item2 = 0;
			List<ISingleItemInfo> list2 = new List<ISingleItemInfo>(list.Count);
			foreach (ISingleItemInfo singleItemInfo in list)
			{
				if (singleItemInfo.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
				{
					list2.Add(singleItemInfo);
				}
				else
				{
					item = true;
					item2 = singleItemInfo.Proto_ItemNum;
				}
			}
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(item, item2, list2);
		}

		// Token: 0x0602D37C RID: 185212 RVA: 0x00CA6184 File Offset: 0x00CA4384
		private void SetSelectedComposeItem(bool isNeedScroll = false)
		{
			int num = 0;
			if (this.TargetItem != 0)
			{
				this.IsRefreshByClick = true;
			}
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.ReagentProductionDataList) : this.GetKeepSelectItemIndex(this.ReagentProductionDataList));
				IReagentProductionData reagentProductionData = this.ReagentProductionDataList[num];
				this.RefreshTips(reagentProductionData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(reagentProductionData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Structure:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.StructureDataList) : this.GetKeepSelectItemIndex(this.StructureDataList));
				IStructureData structureData = this.StructureDataList[num];
				this.RefreshTips(structureData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(structureData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Purification:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.PurificationDataList) : this.GetKeepSelectItemIndex(this.PurificationDataList));
				IPurificationData purificationData = this.PurificationDataList[num];
				this.RefreshTips(purificationData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(purificationData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Exchange:
			{
				num = ((this.TargetItem != 0) ? this.GetExchangeTargetItemIndex(this.ExchangeDataList) : this.GetExchangeKeepSelectItemIndex(this.ExchangeDataList));
				IExchangeData exchangeData = this.ExchangeDataList[num];
				this.RefreshTips(exchangeData, true);
				this.SelectedItemId = exchangeData.ConfigId;
				break;
			}
			case EComposeListType.Collect:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.CollectDataList) : this.GetKeepSelectItemIndex(this.CollectDataList));
				ICollectData collectData = this.CollectDataList[num];
				this.RefreshTips(collectData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(collectData.ConfigId).Value.ItemId;
				break;
			}
			}
			int num3;
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.Exchange)
			{
				int num2 = (num >= 0 && num < this.ExchangeDataList.Count) ? this.ExchangeDataList[num].ConfigId : 0;
				num3 = ((num2 > 0) ? this.ComposeScrollPanel.GetGridIndexByConfigId(num2) : -1);
			}
			else
			{
				num3 = this.ComposeScrollPanel.GetGridIndexByItemIndex(num);
			}
			this.ComposeScrollPanel.DeselectCurrentGridProxy(false);
			if (isNeedScroll && num3 >= 0)
			{
				int scrollAnchorGridIndex = this.ComposeScrollPanel.GetScrollAnchorGridIndex(num3);
				this.ComposeScrollPanel.ScrollToGridIndex(scrollAnchorGridIndex);
			}
			if (num3 >= 0)
			{
				this.ComposeScrollPanel.SelectGridProxy(num3, false);
			}
		}

		// Token: 0x0602D37D RID: 185213 RVA: 0x00CA6448 File Offset: 0x00CA4648
		private int GetExchangeTargetItemIndex(IReadOnlyList<IBaseItemData> itemList)
		{
			int num = NoLinq.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == this.TargetItem);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0602D37E RID: 185214 RVA: 0x00CA6470 File Offset: 0x00CA4670
		private int GetExchangeKeepSelectItemIndex(IReadOnlyList<IBaseItemData> itemList)
		{
			int num = NoLinq.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == this.SelectedItemId);
			if (num >= 0)
			{
				return num;
			}
			int firstConfigId = this.ComposeScrollPanel.GetFirstItemConfigId();
			if (firstConfigId > 0)
			{
				int num2 = NoLinq.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == firstConfigId);
				if (num2 >= 0)
				{
					return num2;
				}
			}
			return 0;
		}

		// Token: 0x0602D37F RID: 185215 RVA: 0x00CA64D8 File Offset: 0x00CA46D8
		private int GetTargetItemIndex(IReadOnlyList<IBaseItemData> itemList)
		{
			int num = NoLinq.FindIndex<IBaseItemData>(itemList, delegate(IBaseItemData data)
			{
				SynthesisFormula? synthesisFormula;
				int? num2 = (ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId) != null) ? new int?(synthesisFormula.GetValueOrDefault().ItemId) : null;
				int targetItem = this.TargetItem;
				return num2.GetValueOrDefault() == targetItem & num2 != null;
			});
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0602D380 RID: 185216 RVA: 0x00CA6500 File Offset: 0x00CA4700
		private int GetKeepSelectItemIndex(IReadOnlyList<IBaseItemData> itemList)
		{
			int num = NoLinq.FindIndex<IBaseItemData>(itemList, delegate(IBaseItemData data)
			{
				SynthesisFormula? synthesisFormula;
				int? num2 = (ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId) != null) ? new int?(synthesisFormula.GetValueOrDefault().ItemId) : null;
				int selectedItemId = this.SelectedItemId;
				return num2.GetValueOrDefault() == selectedItemId & num2 != null;
			});
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x0602D381 RID: 185217 RVA: 0x00CA6528 File Offset: 0x00CA4728
		private void OnComposeItemClick(MediumItemGridExtendCallback callbackParameter)
		{
			IBaseItemData baseItemData = callbackParameter.Data as IBaseItemData;
			if (baseItemData == this.ItemData)
			{
				return;
			}
			this.IsRefreshByClick = true;
			int itemIndex = 0;
			this.ComposeScrollPanel.DeselectCurrentGridProxy(false);
			switch (baseItemData.MainType)
			{
			case EComposeListType.ReagentProduction:
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(baseItemData.ConfigId).Value.ItemId;
				itemIndex = this.ReagentProductionDataList.IndexOf((IReagentProductionData)baseItemData);
				break;
			case EComposeListType.Structure:
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(baseItemData.ConfigId).Value.ItemId;
				itemIndex = this.StructureDataList.IndexOf((IStructureData)baseItemData);
				break;
			case EComposeListType.Purification:
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(baseItemData.ConfigId).Value.ItemId;
				itemIndex = this.PurificationDataList.IndexOf((IPurificationData)baseItemData);
				break;
			case EComposeListType.Exchange:
				this.SelectedItemId = baseItemData.ConfigId;
				itemIndex = this.ExchangeDataList.IndexOf((IExchangeData)baseItemData);
				break;
			case EComposeListType.Collect:
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(baseItemData.ConfigId).Value.ItemId;
				itemIndex = this.CollectDataList.IndexOf((ICollectData)baseItemData);
				break;
			}
			int num = (baseItemData.MainType == EComposeListType.Exchange) ? this.ComposeScrollPanel.GetGridIndexByConfigId(baseItemData.ConfigId) : this.ComposeScrollPanel.GetGridIndexByItemIndex(itemIndex);
			if (num < 0 || !this.ComposeScrollPanel.IsGridDisplaying(num))
			{
				this.IsRefreshByClick = false;
				return;
			}
			if (baseItemData.IsNew)
			{
				NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.ComposeLevelKey, baseItemData.ConfigId);
				baseItemData.IsNew = false;
			}
			this.ComposeScrollPanel.SelectGridProxy(num, false);
			this.ComposeScrollPanel.RefreshGridProxy(num);
			this.RefreshTips(baseItemData, true);
		}

		// Token: 0x0602D382 RID: 185218 RVA: 0x00CA6722 File Offset: 0x00CA4922
		private void BackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602D383 RID: 185219 RVA: 0x00CA672B File Offset: 0x00CA492B
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602D384 RID: 185220 RVA: 0x00CA6734 File Offset: 0x00CA4934
		private void ToggleCallBack(int index)
		{
			this.LastClickTime = Time.Instance.Now;
			EComposeListType ecomposeListType = this.TabList[index];
			if (ComposeModel.Instance.CurrentComposeListType == ecomposeListType)
			{
				return;
			}
			ComposeModel.Instance.CurrentComposeListType = ecomposeListType;
			this.SwitchComposeLevelShow();
			this.SwitchComposeItemScroll();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Switch", true, null, false);
			}
			if (ecomposeListType != EComposeListType.Exchange)
			{
				EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "ComposeCarryOnView");
			}
		}

		// Token: 0x0602D385 RID: 185221 RVA: 0x00CA67C0 File Offset: 0x00CA49C0
		private void SwitchComposeItemScroll()
		{
			this.FilterComponent.SetActive(false);
			this.SortComponent.SetActive(false);
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.ReagentList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId2 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ReagentList);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId2);
				return;
			}
			case EComposeListType.Structure:
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.StructureList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId3 = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.StructureList);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId3);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.StructureList, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId4 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.StructureList);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId4);
				return;
			}
			case EComposeListType.Purification:
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.PurificationList, this.GetItemList(), Array.Empty<object>());
				return;
			case EComposeListType.Exchange:
			{
				this.FilterComponent.UpdateData(EFilterSortGroupId.ComposeExchange, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId5 = this.FilterComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ComposeExchange);
				this.SortComponent.SetFilterUniqueId(uniqueIdByGroupId5);
				this.SortComponent.SetResultDataDirty();
				this.SortComponent.UpdateData(EFilterSortGroupId.ComposeExchange, this.GetItemList(), Array.Empty<object>());
				int uniqueIdByGroupId6 = this.SortComponent.GetUniqueIdByGroupId(EFilterSortGroupId.ComposeExchange);
				this.FilterComponent.SetSortUniqueId(uniqueIdByGroupId6);
				return;
			}
			case EComposeListType.Collect:
				this.OnFilterSortRefresh(this.GetItemList(), false, EFilterSortType.Filter);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D386 RID: 185222 RVA: 0x00CA6998 File Offset: 0x00CA4B98
		public void RefreshTips(IBaseItemData data, bool refreshDrag = true)
		{
			if (this.ItemData != null && this.ItemData.ConfigId != data.ConfigId)
			{
				ComposeModel.Instance.CurrentComposeRoleId = 0;
			}
			this.ItemData = data;
			this.BottomTextNeedShow = false;
			switch (this.ItemData.MainType)
			{
			case EComposeListType.ReagentProduction:
				this.RefreshReagentProduction();
				break;
			case EComposeListType.Structure:
				this.RefreshStructure();
				break;
			case EComposeListType.Purification:
				this.RefreshPurification(refreshDrag);
				break;
			case EComposeListType.Exchange:
				this.RefreshExchange(refreshDrag);
				break;
			case EComposeListType.Collect:
				this.RefreshCollect(refreshDrag);
				break;
			}
			this.CheckCanInteractConfirm();
			this.RefreshLimitTime();
			this.RefreshLimitCount();
			this.RefreshBottomMiddleTips();
			this.RefreshBottomText();
			this.IsRefreshByClick = false;
		}

		// Token: 0x0602D387 RID: 185223 RVA: 0x00CA6A54 File Offset: 0x00CA4C54
		private void CheckCanInteractConfirm()
		{
			ComposeModel instance = ComposeModel.Instance;
			bool flag = true;
			bool flag2 = true;
			bool isCoinEnough = true;
			bool flag3 = true;
			if (this.ItemData.MainType != EComposeListType.Exchange)
			{
				flag = instance.CheckComposeMaterialEnough(this.ItemData.ConfigId);
				flag2 = instance.CheckUnlock(this.ItemData);
				isCoinEnough = instance.CheckCoinEnough(this.ItemData.ConfigId);
				flag3 = instance.CheckLimitCount(this.ItemData);
			}
			base.GetText(38).SetText(this.GetDisableText(flag2, flag, isCoinEnough, flag3), true);
			base.GetItem(25).SetUIActive(!flag2 || !flag || !flag3);
			base.GetButton(24).RootUIComp.Get().SetUIActive(flag2 && flag && flag3);
		}

		// Token: 0x0602D388 RID: 185224 RVA: 0x00CA6B0D File Offset: 0x00CA4D0D
		public void RefreshReagentProduction()
		{
			this.RefreshTopB();
			this.RefreshProficiency(true);
			this.RefreshMaterial();
		}

		// Token: 0x0602D389 RID: 185225 RVA: 0x00CA6B22 File Offset: 0x00CA4D22
		public void RefreshStructure()
		{
			this.RefreshTopB();
			this.RefreshProficiency(false);
			this.RefreshMaterial();
		}

		// Token: 0x0602D38A RID: 185226 RVA: 0x00CA6B37 File Offset: 0x00CA4D37
		public void RefreshPurification(bool refreshDrag = true)
		{
			this.RefreshTopA(refreshDrag);
			if (this.ItemData.IsUnlock <= 0)
			{
				this.NumberSelect.Refresh(0);
			}
			this.RefreshMaterial();
			this.RefreshDragAbout();
		}

		// Token: 0x0602D38B RID: 185227 RVA: 0x00CA6B66 File Offset: 0x00CA4D66
		public void RefreshCollect(bool refreshDrag = true)
		{
			this.RefreshTopA(refreshDrag);
			if (this.ItemData.IsUnlock <= 0)
			{
				this.NumberSelect.Refresh(0);
			}
			this.RefreshMaterial();
			this.RefreshDragAbout();
		}

		// Token: 0x0602D38C RID: 185228 RVA: 0x00CA6B95 File Offset: 0x00CA4D95
		public void RefreshExchange(bool refreshDrag = true)
		{
			this.RefreshTopA(refreshDrag);
			if (this.ItemData.IsUnlock <= 0)
			{
				this.NumberSelect.Refresh(0);
			}
			this.RefreshExchangeMaterial();
			this.RefreshDragAbout();
		}

		// Token: 0x0602D38D RID: 185229 RVA: 0x00CA6BC4 File Offset: 0x00CA4DC4
		private void RefreshTopA(bool refreshDrag = true)
		{
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			SynthesisFormula? synthesisFormula;
			int itemId = (this.ItemData.MainType == EComposeListType.Exchange) ? this.ItemData.ConfigId : ((ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId) != null) ? synthesisFormula.GetValueOrDefault().ItemId : 0);
			string itemName = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemName(itemId);
			base.GetText(6).SetText(itemName, true);
			if (!refreshDrag)
			{
				return;
			}
			List<IBaseItemData> list;
			if (this.IsSingleDirectionExchange(this.ItemData))
			{
				list = new List<IBaseItemData>
				{
					this.ItemData
				};
			}
			else
			{
				list = ComposeModel.Instance.GetSameGroupItem(this.ItemData);
			}
			int attachTo = 0;
			for (int i = 0; i < list.Count; i++)
			{
				if (this.ItemData == list[i])
				{
					attachTo = i;
					break;
				}
			}
			NoCircleAttachView<IBaseItemData, ComposeCircleItem> noCircleExhibitionView = this.NoCircleExhibitionView;
			if (noCircleExhibitionView != null)
			{
				noCircleExhibitionView.ReloadView(list.Count, list.ToArray(), attachTo);
			}
			this.DragList = list;
		}

		// Token: 0x0602D38E RID: 185230 RVA: 0x00CA6CEC File Offset: 0x00CA4EEC
		[NullableContext(2)]
		private bool IsSingleDirectionExchange(IBaseItemData data)
		{
			IExchangeData exchangeData = data as IExchangeData;
			return exchangeData != null && data.MainType == EComposeListType.Exchange && exchangeData.IsSingleDirection;
		}

		// Token: 0x0602D38F RID: 185231 RVA: 0x00CA6D14 File Offset: 0x00CA4F14
		private void RefreshTopB()
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId);
			string itemName = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemName(synthesisFormulaById.Value.ItemId);
			base.GetText(13).SetText(itemName, true);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(synthesisFormulaById.Value.ItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(12), "ItemTipsHaveNum", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(synthesisFormulaById.Value.ItemId);
			if (config == null)
			{
				return;
			}
			base.SetTextureByPath(config.Value.Icon, base.GetTexture(11), null, null);
			string itemAttributeDesc = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemAttributeDesc(synthesisFormulaById.Value.ItemId);
			UUIText text = base.GetText(15);
			if (text != null)
			{
				text.SetText(itemAttributeDesc ?? "", true);
			}
			QualityInfo? qualityConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(config.Value.QualityId);
			if (qualityConfig == null)
			{
				return;
			}
			this.SetSpriteByPath(qualityConfig.Value.ComposeQualityBg, base.GetSprite(10), false, null, null);
		}

		// Token: 0x0602D390 RID: 185232 RVA: 0x00CA6EA0 File Offset: 0x00CA50A0
		private string GetDisableText(bool isUnlock, bool isMatEnough, bool isCoinEnough, bool isMakeCountEnough)
		{
			if (!isUnlock)
			{
				return ConfigMultiTextLang.GetLocalTextNew("GenericPrompt_Unlocked_TipsText", null);
			}
			if (!isMatEnough)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("LackMakeMaterial", null);
				if (!isCoinEnough)
				{
					return StringUtils.Format(localTextNew, new string[]
					{
						CSharpScript.Game.Module.Item.ItemConfig.Instance.GetItemName(ComposeController.Instance.ComposeCoinId)
					});
				}
				return StringUtils.Format(localTextNew, new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew("Material_Text", null)
				});
			}
			else
			{
				if (isMakeCountEnough)
				{
					return "";
				}
				string refreshLimitTime = ComposeModel.Instance.GetRefreshLimitTime();
				if (refreshLimitTime != null)
				{
					return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LackMakeCount", null), new string[]
					{
						refreshLimitTime
					});
				}
				return ConfigMultiTextLang.GetLocalTextNew("LackMakeCountWithoutTime", null);
			}
		}

		// Token: 0x0602D391 RID: 185233 RVA: 0x00CA6F4C File Offset: 0x00CA514C
		private void RefreshLimitCount()
		{
			IBaseItemData itemData = this.ItemData;
			if (itemData.TotalMakeCountInLimitTime <= 0)
			{
				this.NumberSelect.ResetLimitMaxValue();
				base.GetText(21).SetUIActive(false);
				return;
			}
			this.BottomTextNeedShow = true;
			int num = itemData.TotalMakeCountInLimitTime - itemData.MadeCountInLimitTime;
			this.NumberSelect.SetLimitMaxValue(Math.Max(1, num));
			base.GetText(21).SetUIActive(true);
			string text = num.ToString();
			if (num == 0)
			{
				text = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
				{
					num.ToString()
				});
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(21), "MakeLimit", new <>z__ReadOnlyArray<object>(new object[]
			{
				text,
				itemData.TotalMakeCountInLimitTime
			}));
		}

		// Token: 0x0602D392 RID: 185234 RVA: 0x00CA7014 File Offset: 0x00CA5214
		private bool ShouldShowBottomMiddleTips()
		{
			if (this.TipsItemData == null || this.TipsItemData.Count <= 0)
			{
				return false;
			}
			if (this.ItemData.MainType == EComposeListType.Exchange)
			{
				return this.ItemData.ConfigId == this.TipsItemData.ItemId;
			}
			SynthesisFormula? synthesisFormula;
			int? num = (ComposeConfig.Instance.GetSynthesisFormulaById(this.ItemData.ConfigId) != null) ? new int?(synthesisFormula.GetValueOrDefault().ItemId) : null;
			int itemId = this.TipsItemData.ItemId;
			return num.GetValueOrDefault() == itemId & num != null;
		}

		// Token: 0x0602D393 RID: 185235 RVA: 0x00CA70C0 File Offset: 0x00CA52C0
		private void RefreshBottomMiddleTips()
		{
			if (this.ShouldShowBottomMiddleTips())
			{
				this.BottomTextNeedShow = true;
				UUIText text = base.GetText(22);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				int commonItemCount = InventoryModel.Instance.GetCommonItemCount(this.TipsItemData.ItemId, 0);
				int count = this.TipsItemData.Count;
				string text2;
				if (commonItemCount < count)
				{
					text2 = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
					{
						commonItemCount.ToString()
					});
				}
				else
				{
					text2 = StringUtils.Format("<color=#36cd33>{0}</color>", new string[]
					{
						commonItemCount.ToString()
					});
				}
				UUISprite sprite = base.GetSprite(42);
				if (sprite != null)
				{
					sprite.SetUIActive(commonItemCount >= count);
				}
				string textStringId;
				if (this.SkipSourceView != null)
				{
					textStringId = ComposeCarryOnView.SkipViewPrefixMap.GetValueOrDefault(this.SkipSourceView.Value, "ComposeNeedTips");
				}
				else
				{
					textStringId = "ComposeNeedTips";
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(22), textStringId, new <>z__ReadOnlyArray<object>(new object[]
				{
					text2,
					count.ToString()
				}));
			}
			else
			{
				UUIText text3 = base.GetText(22);
				if (text3 != null)
				{
					text3.SetUIActive(false);
				}
			}
			UUIText text4 = base.GetText(43);
			if (text4 == null)
			{
				return;
			}
			text4.SetUIActive(this.ItemData.MainType == EComposeListType.Exchange && this.CurrentSelectExchangeMaterialItem == 0 && !this.IsSingleDirectionExchange(this.ItemData));
		}

		// Token: 0x0602D394 RID: 185236 RVA: 0x00CA7220 File Offset: 0x00CA5420
		private void RefreshBottomText()
		{
			base.GetItem(37).SetUIActive(this.BottomTextNeedShow);
		}

		// Token: 0x0602D395 RID: 185237 RVA: 0x00CA7238 File Offset: 0x00CA5438
		[NullableContext(2)]
		private void MoveDragGrid(IBaseItemData data, EComposeListType type, bool? isFormClick = false)
		{
			if (data == null || this.ItemData == data || this.IsRefreshByClick || ComposeModel.Instance.CurrentComposeListType != type)
			{
				return;
			}
			ComposeModel.Instance.CurrentComposeRoleId = 0;
			this.ItemData = data;
			this.BottomTextNeedShow = false;
			if (this.ItemData.MainType == EComposeListType.Purification)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				this.SelectedItemId = ((synthesisFormulaById != null) ? synthesisFormulaById.GetValueOrDefault().ItemId : 0);
				this.RefreshPurification(false);
			}
			if (this.ItemData.MainType == EComposeListType.Collect)
			{
				SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
				this.SelectedItemId = ((synthesisFormulaById != null) ? synthesisFormulaById.GetValueOrDefault().ItemId : 0);
				this.RefreshCollect(false);
			}
			if (this.ItemData.MainType == EComposeListType.Exchange)
			{
				this.SelectedItemId = data.ConfigId;
				this.RefreshExchange(false);
				this.RefreshExchangeView();
			}
			this.CheckCanInteractConfirm();
			this.RefreshLimitTime();
			this.RefreshLimitCount();
			this.RefreshBottomMiddleTips();
			this.RefreshBottomText();
			this.SelectComposeItem();
			if (isFormClick.GetValueOrDefault())
			{
				this.NoCircleExhibitionViewAttachTo();
			}
		}

		// Token: 0x0602D396 RID: 185238 RVA: 0x00CA7368 File Offset: 0x00CA5568
		private void RefreshDragAbout()
		{
			UUIItem item = base.GetItem(39);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(40);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			IBaseItemData itemData = this.ItemData;
			int? num = (itemData != null) ? new int?(itemData.ConfigId) : null;
			int configId = this.DragList[0].ConfigId;
			if (num.GetValueOrDefault() == configId & num != null)
			{
				UUIItem item3 = base.GetItem(39);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
			}
			IBaseItemData itemData2 = this.ItemData;
			num = ((itemData2 != null) ? new int?(itemData2.ConfigId) : null);
			configId = this.DragList[this.DragList.Count - 1].ConfigId;
			if (num.GetValueOrDefault() == configId & num != null)
			{
				UUIItem item4 = base.GetItem(40);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(false);
			}
		}

		// Token: 0x0602D397 RID: 185239 RVA: 0x00CA745C File Offset: 0x00CA565C
		private void NoCircleExhibitionViewAttachTo()
		{
			int showItemIndex = 0;
			for (int i = 0; i < this.DragList.Count; i++)
			{
				if (this.ItemData == this.DragList[i])
				{
					showItemIndex = i;
					break;
				}
			}
			NoCircleAttachView<IBaseItemData, ComposeCircleItem> noCircleExhibitionView = this.NoCircleExhibitionView;
			if (noCircleExhibitionView == null)
			{
				return;
			}
			noCircleExhibitionView.AttachToIndex(showItemIndex, false);
		}

		// Token: 0x0602D398 RID: 185240 RVA: 0x00CA74AC File Offset: 0x00CA56AC
		private void SelectComposeItem()
		{
			int num = 0;
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				num = this.GetScrollItemIndex(this.ReagentProductionDataList);
				break;
			case EComposeListType.Structure:
				num = this.GetScrollItemIndex(this.StructureDataList);
				break;
			case EComposeListType.Purification:
				num = this.GetScrollItemIndex(this.PurificationDataList);
				break;
			case EComposeListType.Exchange:
				num = this.GetScrollItemIndex(this.ExchangeDataList);
				break;
			case EComposeListType.Collect:
				num = this.GetScrollItemIndex(this.CollectDataList);
				break;
			}
			int num3;
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.Exchange)
			{
				int num2 = (num >= 0 && num < this.ExchangeDataList.Count) ? this.ExchangeDataList[num].ConfigId : 0;
				num3 = ((num2 > 0) ? this.ComposeScrollPanel.GetGridIndexByConfigId(num2) : -1);
			}
			else
			{
				num3 = this.ComposeScrollPanel.GetGridIndexByItemIndex(num);
			}
			if (num3 >= 0)
			{
				this.ComposeScrollPanel.ScrollToGridIndex(num3);
				this.ComposeScrollPanel.SelectGridProxy(num3, false);
				ComposeItemGridProxy gridProxy = this.ComposeScrollPanel.GetGridProxy(num3);
				UUIExtendToggle uuiextendToggle = (gridProxy != null) ? gridProxy.GetInnerGrid().GetItemGridExtendToggle() : null;
				if (uuiextendToggle != null)
				{
					UiNavigationNewController.Instance.SetNavigationFocusForViewSameGroup(uuiextendToggle.RootUIComp);
				}
			}
		}

		// Token: 0x0602D399 RID: 185241 RVA: 0x00CA75DC File Offset: 0x00CA57DC
		private int GetScrollItemIndex(IReadOnlyList<IBaseItemData> dataList)
		{
			int num = NoLinq.IndexOf<IBaseItemData>(dataList, this.ItemData);
			if (num < 0)
			{
				for (int i = 0; i < dataList.Count; i++)
				{
					if (dataList[i].ConfigId == this.ItemData.ConfigId)
					{
						return i;
					}
				}
			}
			return num;
		}

		// Token: 0x0602D39A RID: 185242 RVA: 0x00CA7628 File Offset: 0x00CA5828
		private void OpenLeftPopView()
		{
			UUIItem item = base.GetItem(26);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SetCloseBtnShowState(false);
			}
			GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
			if (materialScrollView != null)
			{
				ManufactureMaterialItem scrollItemByIndex = materialScrollView.GetScrollItemByIndex(0);
				if (scrollItemByIndex != null)
				{
					scrollItemByIndex.SetComposeChangeAble(new bool?(false));
				}
			}
			this.RefreshExchangeView();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("PopupShow", true, null, false);
			}
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "ComposeCarryOnView");
		}

		// Token: 0x0602D39B RID: 185243 RVA: 0x00CA76BC File Offset: 0x00CA58BC
		private void RefreshExchangeView()
		{
			if (!base.GetItem(26).bIsUIActive)
			{
				return;
			}
			List<ISingleItemInfo> exchangeMaterialListByGroupId = ComposeModel.Instance.GetExchangeMaterialListByGroupId((this.ItemData as IExchangeData).ExchangeGroupId);
			ComposeModel.Instance.CurrentExchangeConsume = ComposeModel.Instance.GetExchangeCountByTargetId(this.ItemData.ConfigId);
			List<ISingleItemInfo> list = new List<ISingleItemInfo>(exchangeMaterialListByGroupId.Count);
			foreach (ISingleItemInfo singleItemInfo in exchangeMaterialListByGroupId)
			{
				if (singleItemInfo.Proto_ItemId != this.ItemData.ConfigId)
				{
					list.Add(singleItemInfo);
				}
			}
			list.Sort(delegate(ISingleItemInfo a, ISingleItemInfo b)
			{
				if (a.Proto_ItemNum != b.Proto_ItemNum)
				{
					return b.Proto_ItemNum - a.Proto_ItemNum;
				}
				return a.Proto_ItemId - b.Proto_ItemId;
			});
			LoopScrollView<ComposeExchangeItem, ISingleItemInfo> exchangeScrollView = this.ExchangeScrollView;
			if (exchangeScrollView == null)
			{
				return;
			}
			exchangeScrollView.RefreshByData(list, false, null, false);
		}

		// Token: 0x0602D39C RID: 185244 RVA: 0x00CA77AC File Offset: 0x00CA59AC
		private void OnSecondTimerRefresh(float _)
		{
			this.RefreshItemLimitTime();
			if (this.CheckIsLimitCountRefresh())
			{
				this.<OnSecondTimerRefresh>g__Temp|100_0().Forget();
				return;
			}
			if (this.CheckHasItemTimeOut())
			{
				this.<OnSecondTimerRefresh>g__Temp|100_1().Forget();
			}
		}

		// Token: 0x0602D39D RID: 185245 RVA: 0x00CA77DC File Offset: 0x00CA59DC
		private bool CheckHasItemTimeOut()
		{
			List<IBaseItemData> itemList = this.GetItemList();
			if (itemList == null)
			{
				return false;
			}
			foreach (IBaseItemData baseItemData in itemList)
			{
				if (baseItemData.ExistEndTime > 0.0 && !TimeUtil.Instance.IsInTimeSpan(baseItemData.ExistStartTime, baseItemData.ExistEndTime))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D39E RID: 185246 RVA: 0x00CA7860 File Offset: 0x00CA5A60
		private void OnCookResponse()
		{
			this.TargetItem = this.SelectedItemId;
			this.SwitchComposeItemScroll();
			this.RefreshExchangeView();
			this.TargetItem = 0;
		}

		// Token: 0x0602D39F RID: 185247 RVA: 0x00CA7881 File Offset: 0x00CA5A81
		private bool CheckIsLimitCountRefresh()
		{
			return ComposeModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x0602D3A0 RID: 185248 RVA: 0x00CA789B File Offset: 0x00CA5A9B
		private void RefreshItemLimitTime()
		{
			if (this.ItemData != null && this.ItemData.ExistEndTime > 0.0)
			{
				this.RefreshLimitTime();
				this.RefreshBottomText();
			}
		}

		// Token: 0x0602D3A1 RID: 185249 RVA: 0x00CA78C8 File Offset: 0x00CA5AC8
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.CompositeRewardView)
			{
				return;
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.SetActive(true);
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PlayLevelSequenceByName("Start", false);
			}
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, false);
		}

		// Token: 0x0602D3A2 RID: 185250 RVA: 0x00CA7924 File Offset: 0x00CA5B24
		private void ComposeSwitchType(EComposeListType type, int itemId)
		{
			if (ComposeModel.Instance.CurrentComposeListType == type)
			{
				return;
			}
			ComposeModel.Instance.CurrentComposeListType = type;
			this.TargetItem = itemId;
			this.SwitchComposeLevelShow();
			this.SwitchComposeItemScroll();
			int index = this.TabList.IndexOf(type);
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SelectToggleByIndex(index, true);
			}
			this.SelectedItemId = this.TargetItem;
			this.TargetItem = 0;
			this.OnClickLeftPopItemCloseBtn();
		}

		// Token: 0x0602D3A3 RID: 185251 RVA: 0x00CA7998 File Offset: 0x00CA5B98
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(ComposeDefine.ComposeTypeSprite[this.TabList[index]]), new CommonTabTitleData(ComposeDefine.ComposeTypeName[this.TabList[index]], Array.Empty<object>()), null);
		}

		// Token: 0x0602D3A4 RID: 185252 RVA: 0x00CA79EC File Offset: 0x00CA5BEC
		private ComposeCircleItem CreateCircleItem(AActor actor, int index, int showNum)
		{
			ComposeCircleItem composeCircleItem = new ComposeCircleItem();
			composeCircleItem.CreateByActorAsync(actor, null, false);
			composeCircleItem.ButtonFunction = new Action<IBaseItemData, EComposeListType, bool?>(this.MoveDragGrid);
			composeCircleItem.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
			composeCircleItem.ItemCurve = this.ItemCurve;
			return composeCircleItem;
		}

		// Token: 0x0602D3A5 RID: 185253 RVA: 0x00CA7A38 File Offset: 0x00CA5C38
		private bool CheckToggleCanClick()
		{
			return !this.NoCircleExhibitionView.MovingState();
		}

		// Token: 0x0602D3A6 RID: 185254 RVA: 0x00CA7A4A File Offset: 0x00CA5C4A
		private void OnClickComposeLevelBtn()
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeLevelType;
			UiManager.Instance.OpenView(EUiViewName.ComposeLevelView, null, null);
		}

		// Token: 0x0602D3A7 RID: 185255 RVA: 0x00CA7A68 File Offset: 0x00CA5C68
		private void OnClickConfirmBtn()
		{
			int exchangeCountByTargetId = ComposeModel.Instance.GetExchangeCountByTargetId(this.ItemData.ConfigId);
			if (!base.GetButton(24).IsSelfInteractive)
			{
				ComposeController.Instance.PlayCompositeFailDisplay(delegate
				{
					ComposeController.Instance.PlayCompositeLoopDisplay();
				});
				return;
			}
			this.IsRefreshByClick = true;
			if (this.ItemData.MainType != EComposeListType.Exchange)
			{
				this.<OnClickConfirmBtn>g__SendManufactureAsync|111_1().Forget();
				return;
			}
			if (this.CurrentSelectExchangeMaterialItem == 0)
			{
				this.IsRefreshByClick = false;
				ScrollingTipsController.Instance.ShowTipsByTextId("ComposeExchangeNotFindItemTips", Array.Empty<object>());
				return;
			}
			this.<OnClickConfirmBtn>g__SendExchangeAsync|111_0(exchangeCountByTargetId).Forget();
		}

		// Token: 0x0602D3A8 RID: 185256 RVA: 0x00CA7B18 File Offset: 0x00CA5D18
		private void OnClickLeftPopItemCloseBtn()
		{
			UUIItem item = base.GetItem(26);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			TabComponentWithCaptionItem<CommonTabItem> tabComponent = this.TabComponent;
			if (tabComponent != null)
			{
				tabComponent.SetCloseBtnShowState(true);
			}
			if (this.CurrentSelectExchangeMaterialItem != 0)
			{
				GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
				if (materialScrollView != null)
				{
					ManufactureMaterialItem scrollItemByIndex = materialScrollView.GetScrollItemByIndex(0);
					if (scrollItemByIndex != null)
					{
						scrollItemByIndex.SetComposeChangeAble(new bool?(true));
					}
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("PopupHide", true, null, false);
		}

		// Token: 0x0602D3B0 RID: 185264 RVA: 0x00CA7D80 File Offset: 0x00CA5F80
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|100_0()
		{
			ComposeCarryOnView.<<OnSecondTimerRefresh>g__Temp|100_0>d <<OnSecondTimerRefresh>g__Temp|100_0>d;
			<<OnSecondTimerRefresh>g__Temp|100_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|100_0>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|100_0>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|100_0>d.<>t__builder.Start<ComposeCarryOnView.<<OnSecondTimerRefresh>g__Temp|100_0>d>(ref <<OnSecondTimerRefresh>g__Temp|100_0>d);
			return <<OnSecondTimerRefresh>g__Temp|100_0>d.<>t__builder.Task;
		}

		// Token: 0x0602D3B1 RID: 185265 RVA: 0x00CA7DC4 File Offset: 0x00CA5FC4
		[CompilerGenerated]
		private UniTask <OnSecondTimerRefresh>g__Temp|100_1()
		{
			ComposeCarryOnView.<<OnSecondTimerRefresh>g__Temp|100_1>d <<OnSecondTimerRefresh>g__Temp|100_1>d;
			<<OnSecondTimerRefresh>g__Temp|100_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnSecondTimerRefresh>g__Temp|100_1>d.<>4__this = this;
			<<OnSecondTimerRefresh>g__Temp|100_1>d.<>1__state = -1;
			<<OnSecondTimerRefresh>g__Temp|100_1>d.<>t__builder.Start<ComposeCarryOnView.<<OnSecondTimerRefresh>g__Temp|100_1>d>(ref <<OnSecondTimerRefresh>g__Temp|100_1>d);
			return <<OnSecondTimerRefresh>g__Temp|100_1>d.<>t__builder.Task;
		}

		// Token: 0x0602D3B2 RID: 185266 RVA: 0x00CA7E08 File Offset: 0x00CA6008
		[CompilerGenerated]
		private UniTask <OnClickConfirmBtn>g__SendExchangeAsync|111_0(int itemNum)
		{
			ComposeCarryOnView.<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d <<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d;
			<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.<>4__this = this;
			<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.itemNum = itemNum;
			<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.<>1__state = -1;
			<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.<>t__builder.Start<ComposeCarryOnView.<<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d>(ref <<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d);
			return <<OnClickConfirmBtn>g__SendExchangeAsync|111_0>d.<>t__builder.Task;
		}

		// Token: 0x0602D3B3 RID: 185267 RVA: 0x00CA7E54 File Offset: 0x00CA6054
		[CompilerGenerated]
		private UniTask <OnClickConfirmBtn>g__SendManufactureAsync|111_1()
		{
			ComposeCarryOnView.<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d <<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d;
			<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d.<>4__this = this;
			<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d.<>1__state = -1;
			<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d.<>t__builder.Start<ComposeCarryOnView.<<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d>(ref <<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d);
			return <<OnClickConfirmBtn>g__SendManufactureAsync|111_1>d.<>t__builder.Task;
		}

		// Token: 0x040183F2 RID: 99314
		private const int GAP = 112;

		// Token: 0x040183F3 RID: 99315
		private const int TIMERGAP = 1000;

		// Token: 0x040183F4 RID: 99316
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EUiViewName, string> SkipViewPrefixMap = new Dictionary<EUiViewName, string>
		{
			{
				EUiViewName.RoleBreachView,
				"AutoSynthesis_ResonatorsAscendMaterial_Num"
			},
			{
				EUiViewName.WeaponRootView,
				"AutoSynthesis_WeaponAscendMaterial_Num"
			},
			{
				EUiViewName.RoleSkillTreeInfoView,
				"AutoSynthesis_ForteUpgradeMaterial_Num"
			}
		};

		// Token: 0x040183F5 RID: 99317
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x040183F6 RID: 99318
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x040183F7 RID: 99319
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IBaseItemData> FilterComponent;

		// Token: 0x040183F8 RID: 99320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IBaseItemData> SortComponent;

		// Token: 0x040183F9 RID: 99321
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x040183FA RID: 99322
		[Nullable(2)]
		private ComposeCarryOnMultiTemplatePanel ComposeScrollPanel;

		// Token: 0x040183FB RID: 99323
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x040183FC RID: 99324
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x040183FD RID: 99325
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<IBaseItemData, ComposeCircleItem> NoCircleExhibitionView;

		// Token: 0x040183FE RID: 99326
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ComposeExchangeItem, ISingleItemInfo> ExchangeScrollView;

		// Token: 0x040183FF RID: 99327
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectExchangeScrollToggle;

		// Token: 0x04018400 RID: 99328
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018401 RID: 99329
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x04018402 RID: 99330
		private bool HasCoin;

		// Token: 0x04018403 RID: 99331
		private int SingleNeedCoinCount;

		// Token: 0x04018404 RID: 99332
		private int Count = 1;

		// Token: 0x04018405 RID: 99333
		private int SelectedItemId;

		// Token: 0x04018406 RID: 99334
		private List<IReagentProductionData> ReagentProductionDataList = new List<IReagentProductionData>();

		// Token: 0x04018407 RID: 99335
		private List<IStructureData> StructureDataList = new List<IStructureData>();

		// Token: 0x04018408 RID: 99336
		private List<IPurificationData> PurificationDataList = new List<IPurificationData>();

		// Token: 0x04018409 RID: 99337
		private List<ICollectData> CollectDataList = new List<ICollectData>();

		// Token: 0x0401840A RID: 99338
		private List<IExchangeData> ExchangeDataList = new List<IExchangeData>();

		// Token: 0x0401840B RID: 99339
		private List<EComposeListType> TabList = new List<EComposeListType>();

		// Token: 0x0401840C RID: 99340
		private bool BottomTextNeedShow;

		// Token: 0x0401840D RID: 99341
		[Nullable(2)]
		private UCurveFloat ItemCurve;

		// Token: 0x0401840E RID: 99342
		private bool IsRefreshByClick;

		// Token: 0x0401840F RID: 99343
		private int CurrentSelectExchangeMaterialItem;

		// Token: 0x04018410 RID: 99344
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x04018411 RID: 99345
		[Nullable(2)]
		private ISelectedData TipsItemData;

		// Token: 0x04018412 RID: 99346
		private int TargetItem;

		// Token: 0x04018413 RID: 99347
		private double LastClickTime;

		// Token: 0x04018414 RID: 99348
		private List<IBaseItemData> DragList = new List<IBaseItemData>();

		// Token: 0x04018415 RID: 99349
		private EUiViewName? SkipSourceView;

		// Token: 0x0200A24D RID: 41549
		[NullableContext(0)]
		public class EComponentDefine
		{
			// Token: 0x04032596 RID: 206230
			public const int CaptionItem = 0;

			// Token: 0x04032597 RID: 206231
			public const int LeftMultiTemplateScrollView = 1;

			// Token: 0x04032598 RID: 206232
			public const int LeftScrollItem = 2;

			// Token: 0x04032599 RID: 206233
			public const int SortItem = 3;

			// Token: 0x0403259A RID: 206234
			public const int ComposeLevelBtn = 4;

			// Token: 0x0403259B RID: 206235
			public const int DragRootItem = 5;

			// Token: 0x0403259C RID: 206236
			public const int DragItemNameText = 6;

			// Token: 0x0403259D RID: 206237
			public const int DragComponent = 7;

			// Token: 0x0403259E RID: 206238
			public const int DragItem = 8;

			// Token: 0x0403259F RID: 206239
			public const int ItemDesRootItem = 9;

			// Token: 0x040325A0 RID: 206240
			public const int ItemDesQualitySprint = 10;

			// Token: 0x040325A1 RID: 206241
			public const int ItemDesTexture = 11;

			// Token: 0x040325A2 RID: 206242
			public const int ItemDesNumText = 12;

			// Token: 0x040325A3 RID: 206243
			public const int ItemDesNameText = 13;

			// Token: 0x040325A4 RID: 206244
			public const int ItemDesSubTitleText = 14;

			// Token: 0x040325A5 RID: 206245
			public const int ItemDesMainText = 15;

			// Token: 0x040325A6 RID: 206246
			public const int BottomLockItem = 16;

			// Token: 0x040325A7 RID: 206247
			public const int BottomScrollView = 17;

			// Token: 0x040325A8 RID: 206248
			public const int BottomScrollItem = 18;

			// Token: 0x040325A9 RID: 206249
			public const int BottomAddItem = 19;

			// Token: 0x040325AA RID: 206250
			public const int BottomDesText = 20;

			// Token: 0x040325AB RID: 206251
			public const int BottomLeftText = 21;

			// Token: 0x040325AC RID: 206252
			public const int BottomMidText = 22;

			// Token: 0x040325AD RID: 206253
			public const int BottomTimeText = 23;

			// Token: 0x040325AE RID: 206254
			public const int ConfirmBtn = 24;

			// Token: 0x040325AF RID: 206255
			public const int LockItem = 25;

			// Token: 0x040325B0 RID: 206256
			public const int LeftPopItem = 26;

			// Token: 0x040325B1 RID: 206257
			public const int LeftPopItemCloseBtn = 27;

			// Token: 0x040325B2 RID: 206258
			public const int LeftPopItemScrollView = 28;

			// Token: 0x040325B3 RID: 206259
			public const int LeftPopItemScrollItem = 29;

			// Token: 0x040325B4 RID: 206260
			public const int MakeCountText = 30;

			// Token: 0x040325B5 RID: 206261
			public const int CostTxt = 31;

			// Token: 0x040325B6 RID: 206262
			public const int CostIconTexture = 32;

			// Token: 0x040325B7 RID: 206263
			public const int FilterItem = 33;

			// Token: 0x040325B8 RID: 206264
			public const int RedDotItem = 34;

			// Token: 0x040325B9 RID: 206265
			public const int ComposeLevelSprite = 35;

			// Token: 0x040325BA RID: 206266
			public const int StarLayout = 36;

			// Token: 0x040325BB RID: 206267
			public const int BottomTextRootItem = 37;

			// Token: 0x040325BC RID: 206268
			public const int TxtActivate = 38;

			// Token: 0x040325BD RID: 206269
			public const int DragLeftItem = 39;

			// Token: 0x040325BE RID: 206270
			public const int DragRightItem = 40;

			// Token: 0x040325BF RID: 206271
			public const int DragContentItem = 41;

			// Token: 0x040325C0 RID: 206272
			public const int SprCheck = 42;

			// Token: 0x040325C1 RID: 206273
			public const int TxtTips = 43;

			// Token: 0x040325C2 RID: 206274
			public const int PnlTitle = 44;

			// Token: 0x040325C3 RID: 206275
			public const int TxtTitle = 45;
		}
	}
}
