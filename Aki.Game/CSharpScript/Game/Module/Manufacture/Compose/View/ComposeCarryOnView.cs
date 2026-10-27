using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x0200566D RID: 22125
	[NullableContext(1)]
	[Nullable(0)]
	public class ComposeCarryOnView : UiViewBase
	{
		// Token: 0x0603845F RID: 230495 RVA: 0x00D5654C File Offset: 0x00D5474C
		public ComposeCarryOnView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038460 RID: 230496 RVA: 0x00D565B4 File Offset: 0x00D547B4
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

		// Token: 0x06038461 RID: 230497 RVA: 0x00D56C74 File Offset: 0x00D54E74
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

		// Token: 0x06038462 RID: 230498 RVA: 0x00D56D50 File Offset: 0x00D54F50
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

		// Token: 0x06038463 RID: 230499 RVA: 0x00D56E34 File Offset: 0x00D55034
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeCarryOnView.<OnBeforeStartAsync>d__41 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeCarryOnView.<OnBeforeStartAsync>d__41>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038464 RID: 230500 RVA: 0x00D56E77 File Offset: 0x00D55077
		protected override void OnStart()
		{
			CommonManager.Instance.SetCurrentSystem(ESystemType.ComposeSystem);
		}

		// Token: 0x06038465 RID: 230501 RVA: 0x00D56E84 File Offset: 0x00D55084
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

		// Token: 0x06038466 RID: 230502 RVA: 0x00D56F05 File Offset: 0x00D55105
		protected override void OnBeforeDestroy()
		{
			ComposeModel.Instance.CurrentComposeListType = EComposeListType.Purification;
		}

		// Token: 0x06038467 RID: 230503 RVA: 0x00D56F14 File Offset: 0x00D55114
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

		// Token: 0x06038468 RID: 230504 RVA: 0x00D56F78 File Offset: 0x00D55178
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

		// Token: 0x06038469 RID: 230505 RVA: 0x00D57028 File Offset: 0x00D55228
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

		// Token: 0x0603846A RID: 230506 RVA: 0x00D5708C File Offset: 0x00D5528C
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

		// Token: 0x0603846B RID: 230507 RVA: 0x00D5710C File Offset: 0x00D5530C
		private void RefreshMaterialNeedNum()
		{
			this.RefreshCost(this.HasCoin, this.SingleNeedCoinCount * this.Count);
			if (this.ItemData != null && ComposeModel.Instance.IsInPurificationList())
			{
				List<IComposeItemData> source = ComposeModel.Instance.CalculateNeedComposeMaterialList(this.ItemData.ConfigId, this.Count);
				ComposeModel.Instance.SetCurrentComposeMaterialList((from item in source
				select new SingleItemInfo
				{
					ItemId = item.ItemId,
					ItemNum = item.RequiredNum
				}).ToList<SingleItemInfo>());
				List<IComposeItemData> uiList = source.AsEnumerable<IComposeItemData>().Reverse<IComposeItemData>().ToList<IComposeItemData>();
				GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView = this.MaterialScrollView;
				if (materialScrollView == null)
				{
					return;
				}
				materialScrollView.RefreshByData((from item in uiList
				select new ISingleItemInfo
				{
					Proto_ItemId = item.ItemId,
					Proto_ItemNum = item.RequiredNum,
					Proto_IsUnlock = true
				}).ToList<ISingleItemInfo>(), delegate
				{
					GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView3 = this.MaterialScrollView;
					List<ManufactureMaterialItem> list2 = (materialScrollView3 != null) ? materialScrollView3.GetScrollItemList() : null;
					if (list2 != null)
					{
						for (int i = 0; i < list2.Count; i++)
						{
							list2[i].SetNeedNum(uiList[i].RequiredNum);
						}
					}
				}, false);
				return;
			}
			else
			{
				GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> materialScrollView2 = this.MaterialScrollView;
				List<ManufactureMaterialItem> list = (materialScrollView2 != null) ? materialScrollView2.GetScrollItemList() : null;
				if (list == null)
				{
					return;
				}
				foreach (ManufactureMaterialItem manufactureMaterialItem in list)
				{
					manufactureMaterialItem.SetUiActive(true);
					manufactureMaterialItem.SetTimes(this.Count);
				}
				return;
			}
		}

		// Token: 0x0603846C RID: 230508 RVA: 0x00D57270 File Offset: 0x00D55470
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

		// Token: 0x0603846D RID: 230509 RVA: 0x00D57358 File Offset: 0x00D55558
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

		// Token: 0x0603846E RID: 230510 RVA: 0x00D574F0 File Offset: 0x00D556F0
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
				ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null);
			});
			manufactureMaterialItem.BindEmptySlotButtonCallback(delegate(MediumItemGridButtonCallback _)
			{
				this.OpenLeftPopView();
			});
			return manufactureMaterialItem;
		}

		// Token: 0x0603846F RID: 230511 RVA: 0x00D5754B File Offset: 0x00D5574B
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
					ItemController.Instance.OpenItemTipsByItemId(singleItemInfo.Proto_ItemId, true, null);
					return;
				}
				this.CurrentSelectExchangeMaterialItem = singleItemInfo.Proto_ItemId;
				this.RefreshExchangeMaterialBySelect(null);
			});
			return composeExchangeItem;
		}

		// Token: 0x06038470 RID: 230512 RVA: 0x00D57564 File Offset: 0x00D55764
		private void OnFilterSortRefresh(List<IBaseItemData> list, bool arg1, EFilterSortType arg2)
		{
			IEnumerable<IBaseItemData> source = from data in list
			where data.ExistStartTime <= 0.0 || TimeUtil.Instance.IsInTimeSpan(data.ExistStartTime, data.ExistEndTime)
			select data;
			this.SelectedItemId = 0;
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				this.ReagentProductionDataList = source.Cast<IReagentProductionData>().ToList<IReagentProductionData>();
				break;
			case EComposeListType.Structure:
				this.StructureDataList = source.Cast<IStructureData>().ToList<IStructureData>();
				break;
			case EComposeListType.Purification:
				this.PurificationDataList = source.Cast<IPurificationData>().ToList<IPurificationData>();
				break;
			case EComposeListType.Exchange:
				this.ExchangeDataList = source.Cast<IExchangeData>().ToList<IExchangeData>();
				break;
			case EComposeListType.Collect:
				this.CollectDataList = source.Cast<ICollectData>().ToList<ICollectData>();
				break;
			}
			this.ComposeScrollPanel.DeselectCurrentGridProxy(false);
			this.RefreshItemScrollView();
			if (source.Count<IBaseItemData>() == 0)
			{
				return;
			}
			this.SetSelectedComposeItem(true);
		}

		// Token: 0x06038471 RID: 230513 RVA: 0x00D57648 File Offset: 0x00D55848
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

		// Token: 0x06038472 RID: 230514 RVA: 0x00D5776C File Offset: 0x00D5596C
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

		// Token: 0x06038473 RID: 230515 RVA: 0x00D57815 File Offset: 0x00D55A15
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IBaseItemData> GetItemList()
		{
			return this.GetItemListByType(ComposeModel.Instance.CurrentComposeListType);
		}

		// Token: 0x06038474 RID: 230516 RVA: 0x00D57828 File Offset: 0x00D55A28
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

		// Token: 0x06038475 RID: 230517 RVA: 0x00D5797C File Offset: 0x00D55B7C
		private void SwitchComposeLevelShow()
		{
			(base.GetButton(4).GetOwner() as AUIBaseActor).GetUIItem().SetUIActive(ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction);
			int? composeMaxLevel = CommonManager.Instance.GetComposeMaxLevel();
			int? currentRewardLevel = CommonManager.Instance.GetCurrentRewardLevel();
			this.StartLevelComponent.ShowLevel(currentRewardLevel.Value, composeMaxLevel.Value);
			this.SetComposeLevelSprite();
		}

		// Token: 0x06038476 RID: 230518 RVA: 0x00D579E6 File Offset: 0x00D55BE6
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

		// Token: 0x06038477 RID: 230519 RVA: 0x00D57A18 File Offset: 0x00D55C18
		private void SetComposeLevelSprite()
		{
			if (ComposeModel.Instance.CurrentComposeListType == EComposeListType.ReagentProduction)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ReagentProductionLevel");
				this.SetSpriteByPath(resourcePath, base.GetSprite(35), false, null, null);
			}
		}

		// Token: 0x06038478 RID: 230520 RVA: 0x00D57A5C File Offset: 0x00D55C5C
		private void OnShowRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.ComposeReagentProduction, base.GetItem(34), null, 0);
		}

		// Token: 0x06038479 RID: 230521 RVA: 0x00D57A74 File Offset: 0x00D55C74
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

		// Token: 0x0603847A RID: 230522 RVA: 0x00D57B48 File Offset: 0x00D55D48
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

		// Token: 0x0603847B RID: 230523 RVA: 0x00D57E88 File Offset: 0x00D56088
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

		// Token: 0x0603847C RID: 230524 RVA: 0x00D57F54 File Offset: 0x00D56154
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

		// Token: 0x0603847D RID: 230525 RVA: 0x00D57FE0 File Offset: 0x00D561E0
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
			bool hasCoin = false;
			int coinCount = 0;
			List<ISingleItemInfo> item = list.Where(delegate(ISingleItemInfo value)
			{
				if (value.Proto_ItemId != ComposeController.Instance.ComposeCoinId)
				{
					return true;
				}
				hasCoin = true;
				coinCount = value.Proto_ItemNum;
				return false;
			}).ToList<ISingleItemInfo>();
			return new ValueTuple<bool, int, List<ISingleItemInfo>>(hasCoin, coinCount, item);
		}

		// Token: 0x0603847E RID: 230526 RVA: 0x00D5802C File Offset: 0x00D5622C
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
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.ReagentProductionDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()) : this.GetKeepSelectItemIndex(this.ReagentProductionDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()));
				IReagentProductionData reagentProductionData = this.ReagentProductionDataList[num];
				this.RefreshTips(reagentProductionData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(reagentProductionData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Structure:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.StructureDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()) : this.GetKeepSelectItemIndex(this.StructureDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()));
				IStructureData structureData = this.StructureDataList[num];
				this.RefreshTips(structureData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(structureData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Purification:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.PurificationDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()) : this.GetKeepSelectItemIndex(this.PurificationDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()));
				IPurificationData purificationData = this.PurificationDataList[num];
				this.RefreshTips(purificationData, true);
				this.SelectedItemId = ComposeConfig.Instance.GetSynthesisFormulaById(purificationData.ConfigId).Value.ItemId;
				break;
			}
			case EComposeListType.Exchange:
			{
				num = ((this.TargetItem != 0) ? this.GetExchangeTargetItemIndex(this.ExchangeDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()) : this.GetExchangeKeepSelectItemIndex(this.ExchangeDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()));
				IExchangeData exchangeData = this.ExchangeDataList[num];
				this.RefreshTips(exchangeData, true);
				this.SelectedItemId = exchangeData.ConfigId;
				break;
			}
			case EComposeListType.Collect:
			{
				num = ((this.TargetItem != 0) ? this.GetTargetItemIndex(this.CollectDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()) : this.GetKeepSelectItemIndex(this.CollectDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>()));
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

		// Token: 0x0603847F RID: 230527 RVA: 0x00D58354 File Offset: 0x00D56554
		private int GetExchangeTargetItemIndex(IBaseItemData[] itemList)
		{
			int num = Array.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == this.TargetItem);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06038480 RID: 230528 RVA: 0x00D5837C File Offset: 0x00D5657C
		private int GetExchangeKeepSelectItemIndex(IBaseItemData[] itemList)
		{
			int num = Array.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == this.SelectedItemId);
			if (num >= 0)
			{
				return num;
			}
			int firstConfigId = this.ComposeScrollPanel.GetFirstItemConfigId();
			if (firstConfigId > 0)
			{
				int num2 = Array.FindIndex<IBaseItemData>(itemList, (IBaseItemData data) => data.ConfigId == firstConfigId);
				if (num2 >= 0)
				{
					return num2;
				}
			}
			return 0;
		}

		// Token: 0x06038481 RID: 230529 RVA: 0x00D583E4 File Offset: 0x00D565E4
		private int GetTargetItemIndex(IBaseItemData[] itemList)
		{
			int num = Array.FindIndex<IBaseItemData>(itemList, delegate(IBaseItemData data)
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

		// Token: 0x06038482 RID: 230530 RVA: 0x00D5840C File Offset: 0x00D5660C
		private int GetKeepSelectItemIndex(IBaseItemData[] itemList)
		{
			int num = Array.FindIndex<IBaseItemData>(itemList, delegate(IBaseItemData data)
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

		// Token: 0x06038483 RID: 230531 RVA: 0x00D58434 File Offset: 0x00D56634
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

		// Token: 0x06038484 RID: 230532 RVA: 0x00D5862E File Offset: 0x00D5682E
		private void BackClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038485 RID: 230533 RVA: 0x00D58637 File Offset: 0x00D56837
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06038486 RID: 230534 RVA: 0x00D58640 File Offset: 0x00D56840
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

		// Token: 0x06038487 RID: 230535 RVA: 0x00D586CC File Offset: 0x00D568CC
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

		// Token: 0x06038488 RID: 230536 RVA: 0x00D588A4 File Offset: 0x00D56AA4
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

		// Token: 0x06038489 RID: 230537 RVA: 0x00D58960 File Offset: 0x00D56B60
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

		// Token: 0x0603848A RID: 230538 RVA: 0x00D58A19 File Offset: 0x00D56C19
		public void RefreshReagentProduction()
		{
			this.RefreshTopB();
			this.RefreshProficiency(true);
			this.RefreshMaterial();
		}

		// Token: 0x0603848B RID: 230539 RVA: 0x00D58A2E File Offset: 0x00D56C2E
		public void RefreshStructure()
		{
			this.RefreshTopB();
			this.RefreshProficiency(false);
			this.RefreshMaterial();
		}

		// Token: 0x0603848C RID: 230540 RVA: 0x00D58A43 File Offset: 0x00D56C43
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

		// Token: 0x0603848D RID: 230541 RVA: 0x00D58A72 File Offset: 0x00D56C72
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

		// Token: 0x0603848E RID: 230542 RVA: 0x00D58AA1 File Offset: 0x00D56CA1
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

		// Token: 0x0603848F RID: 230543 RVA: 0x00D58AD0 File Offset: 0x00D56CD0
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

		// Token: 0x06038490 RID: 230544 RVA: 0x00D58BF8 File Offset: 0x00D56DF8
		[NullableContext(2)]
		private bool IsSingleDirectionExchange(IBaseItemData data)
		{
			IExchangeData exchangeData = data as IExchangeData;
			return exchangeData != null && data.MainType == EComposeListType.Exchange && exchangeData.IsSingleDirection;
		}

		// Token: 0x06038491 RID: 230545 RVA: 0x00D58C20 File Offset: 0x00D56E20
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

		// Token: 0x06038492 RID: 230546 RVA: 0x00D58DAC File Offset: 0x00D56FAC
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

		// Token: 0x06038493 RID: 230547 RVA: 0x00D58E58 File Offset: 0x00D57058
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

		// Token: 0x06038494 RID: 230548 RVA: 0x00D58F20 File Offset: 0x00D57120
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

		// Token: 0x06038495 RID: 230549 RVA: 0x00D58FCC File Offset: 0x00D571CC
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

		// Token: 0x06038496 RID: 230550 RVA: 0x00D5912C File Offset: 0x00D5732C
		private void RefreshBottomText()
		{
			base.GetItem(37).SetUIActive(this.BottomTextNeedShow);
		}

		// Token: 0x06038497 RID: 230551 RVA: 0x00D59144 File Offset: 0x00D57344
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

		// Token: 0x06038498 RID: 230552 RVA: 0x00D59274 File Offset: 0x00D57474
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

		// Token: 0x06038499 RID: 230553 RVA: 0x00D59368 File Offset: 0x00D57568
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

		// Token: 0x0603849A RID: 230554 RVA: 0x00D593B8 File Offset: 0x00D575B8
		private void SelectComposeItem()
		{
			int num = 0;
			switch (ComposeModel.Instance.CurrentComposeListType)
			{
			case EComposeListType.ReagentProduction:
				num = this.GetScrollItemIndex(this.ReagentProductionDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>());
				break;
			case EComposeListType.Structure:
				num = this.GetScrollItemIndex(this.StructureDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>());
				break;
			case EComposeListType.Purification:
				num = this.GetScrollItemIndex(this.PurificationDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>());
				break;
			case EComposeListType.Exchange:
				num = this.GetScrollItemIndex(this.ExchangeDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>());
				break;
			case EComposeListType.Collect:
				num = this.GetScrollItemIndex(this.CollectDataList.Cast<IBaseItemData>().ToArray<IBaseItemData>());
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

		// Token: 0x0603849B RID: 230555 RVA: 0x00D59518 File Offset: 0x00D57718
		private int GetScrollItemIndex(IBaseItemData[] dataList)
		{
			int num = Array.IndexOf<IBaseItemData>(dataList, this.ItemData);
			if (num < 0)
			{
				for (int i = 0; i < dataList.Length; i++)
				{
					if (dataList[i].ConfigId == this.ItemData.ConfigId)
					{
						return i;
					}
				}
			}
			return num;
		}

		// Token: 0x0603849C RID: 230556 RVA: 0x00D5955C File Offset: 0x00D5775C
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

		// Token: 0x0603849D RID: 230557 RVA: 0x00D595F0 File Offset: 0x00D577F0
		private void RefreshExchangeView()
		{
			if (!base.GetItem(26).bIsUIActive)
			{
				return;
			}
			IEnumerable<ISingleItemInfo> exchangeMaterialListByGroupId = ComposeModel.Instance.GetExchangeMaterialListByGroupId((this.ItemData as IExchangeData).ExchangeGroupId);
			ComposeModel.Instance.CurrentExchangeConsume = ComposeModel.Instance.GetExchangeCountByTargetId(this.ItemData.ConfigId);
			List<ISingleItemInfo> list = (from item in exchangeMaterialListByGroupId
			where item.Proto_ItemId != this.ItemData.ConfigId
			select item).ToList<ISingleItemInfo>();
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

		// Token: 0x0603849E RID: 230558 RVA: 0x00D59696 File Offset: 0x00D57896
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

		// Token: 0x0603849F RID: 230559 RVA: 0x00D596C8 File Offset: 0x00D578C8
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

		// Token: 0x060384A0 RID: 230560 RVA: 0x00D5974C File Offset: 0x00D5794C
		private void OnCookResponse()
		{
			this.TargetItem = this.SelectedItemId;
			this.SwitchComposeItemScroll();
			this.RefreshExchangeView();
			this.TargetItem = 0;
		}

		// Token: 0x060384A1 RID: 230561 RVA: 0x00D5976D File Offset: 0x00D5796D
		private bool CheckIsLimitCountRefresh()
		{
			return ComposeModel.Instance.GetRefreshLimitTimeValue() <= 0.0;
		}

		// Token: 0x060384A2 RID: 230562 RVA: 0x00D59787 File Offset: 0x00D57987
		private void RefreshItemLimitTime()
		{
			if (this.ItemData != null && this.ItemData.ExistEndTime > 0.0)
			{
				this.RefreshLimitTime();
				this.RefreshBottomText();
			}
		}

		// Token: 0x060384A3 RID: 230563 RVA: 0x00D597B4 File Offset: 0x00D579B4
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

		// Token: 0x060384A4 RID: 230564 RVA: 0x00D59810 File Offset: 0x00D57A10
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

		// Token: 0x060384A5 RID: 230565 RVA: 0x00D59884 File Offset: 0x00D57A84
		private CommonTabData GetCommonData(int index)
		{
			return new CommonTabData(UiResourceConfig.Instance.GetResourcePath(ComposeDefine.ComposeTypeSprite[this.TabList[index]]), new CommonTabTitleData(ComposeDefine.ComposeTypeName[this.TabList[index]], Array.Empty<object>()), null);
		}

		// Token: 0x060384A6 RID: 230566 RVA: 0x00D598D8 File Offset: 0x00D57AD8
		private ComposeCircleItem CreateCircleItem(AActor actor, int index, int showNum)
		{
			ComposeCircleItem composeCircleItem = new ComposeCircleItem();
			composeCircleItem.CreateByActorAsync(actor, null, false);
			composeCircleItem.ButtonFunction = new Action<IBaseItemData, EComposeListType, bool?>(this.MoveDragGrid);
			composeCircleItem.CheckToggleCanClick = new Func<bool>(this.CheckToggleCanClick);
			composeCircleItem.ItemCurve = this.ItemCurve;
			return composeCircleItem;
		}

		// Token: 0x060384A7 RID: 230567 RVA: 0x00D59924 File Offset: 0x00D57B24
		private bool CheckToggleCanClick()
		{
			return !this.NoCircleExhibitionView.MovingState();
		}

		// Token: 0x060384A8 RID: 230568 RVA: 0x00D59936 File Offset: 0x00D57B36
		private void OnClickComposeLevelBtn()
		{
			ComposeModel.Instance.CurrentComposeViewType = EComposeViewType.ComposeLevelType;
			UiManager.Instance.OpenView(EUiViewName.ComposeLevelView, null, null);
		}

		// Token: 0x060384A9 RID: 230569 RVA: 0x00D59954 File Offset: 0x00D57B54
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

		// Token: 0x060384AA RID: 230570 RVA: 0x00D59A04 File Offset: 0x00D57C04
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

		// Token: 0x060384B3 RID: 230579 RVA: 0x00D59C80 File Offset: 0x00D57E80
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

		// Token: 0x060384B4 RID: 230580 RVA: 0x00D59CC4 File Offset: 0x00D57EC4
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

		// Token: 0x060384B5 RID: 230581 RVA: 0x00D59D08 File Offset: 0x00D57F08
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

		// Token: 0x060384B6 RID: 230582 RVA: 0x00D59D54 File Offset: 0x00D57F54
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

		// Token: 0x0401D967 RID: 121191
		private const int GAP = 112;

		// Token: 0x0401D968 RID: 121192
		private const int TIMERGAP = 1000;

		// Token: 0x0401D969 RID: 121193
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

		// Token: 0x0401D96A RID: 121194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

		// Token: 0x0401D96B RID: 121195
		[Nullable(2)]
		private NumberSelectComponent NumberSelect;

		// Token: 0x0401D96C RID: 121196
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FilterEntrance<IBaseItemData> FilterComponent;

		// Token: 0x0401D96D RID: 121197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private SortEntrance<IBaseItemData> SortComponent;

		// Token: 0x0401D96E RID: 121198
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ManufactureMaterialItem, ISingleItemInfo> MaterialScrollView;

		// Token: 0x0401D96F RID: 121199
		[Nullable(2)]
		private ComposeCarryOnMultiTemplatePanel ComposeScrollPanel;

		// Token: 0x0401D970 RID: 121200
		[Nullable(2)]
		private StarLevelComponent StartLevelComponent;

		// Token: 0x0401D971 RID: 121201
		[Nullable(2)]
		private MediumItemGrid UnlockMaterialComponent;

		// Token: 0x0401D972 RID: 121202
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private NoCircleAttachView<IBaseItemData, ComposeCircleItem> NoCircleExhibitionView;

		// Token: 0x0401D973 RID: 121203
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ComposeExchangeItem, ISingleItemInfo> ExchangeScrollView;

		// Token: 0x0401D974 RID: 121204
		[Nullable(2)]
		private UUIExtendToggle CurrentSelectExchangeScrollToggle;

		// Token: 0x0401D975 RID: 121205
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401D976 RID: 121206
		[Nullable(2)]
		private IBaseItemData ItemData;

		// Token: 0x0401D977 RID: 121207
		private bool HasCoin;

		// Token: 0x0401D978 RID: 121208
		private int SingleNeedCoinCount;

		// Token: 0x0401D979 RID: 121209
		private int Count = 1;

		// Token: 0x0401D97A RID: 121210
		private int SelectedItemId;

		// Token: 0x0401D97B RID: 121211
		private List<IReagentProductionData> ReagentProductionDataList = new List<IReagentProductionData>();

		// Token: 0x0401D97C RID: 121212
		private List<IStructureData> StructureDataList = new List<IStructureData>();

		// Token: 0x0401D97D RID: 121213
		private List<IPurificationData> PurificationDataList = new List<IPurificationData>();

		// Token: 0x0401D97E RID: 121214
		private List<ICollectData> CollectDataList = new List<ICollectData>();

		// Token: 0x0401D97F RID: 121215
		private List<IExchangeData> ExchangeDataList = new List<IExchangeData>();

		// Token: 0x0401D980 RID: 121216
		private List<EComposeListType> TabList = new List<EComposeListType>();

		// Token: 0x0401D981 RID: 121217
		private bool BottomTextNeedShow;

		// Token: 0x0401D982 RID: 121218
		[Nullable(2)]
		private UCurveFloat ItemCurve;

		// Token: 0x0401D983 RID: 121219
		private bool IsRefreshByClick;

		// Token: 0x0401D984 RID: 121220
		private int CurrentSelectExchangeMaterialItem;

		// Token: 0x0401D985 RID: 121221
		[Nullable(2)]
		private TimerHandle RefreshTimer;

		// Token: 0x0401D986 RID: 121222
		[Nullable(2)]
		private ISelectedData TipsItemData;

		// Token: 0x0401D987 RID: 121223
		private int TargetItem;

		// Token: 0x0401D988 RID: 121224
		private double LastClickTime;

		// Token: 0x0401D989 RID: 121225
		private List<IBaseItemData> DragList = new List<IBaseItemData>();

		// Token: 0x0401D98A RID: 121226
		private EUiViewName? SkipSourceView;

		// Token: 0x0200B824 RID: 47140
		[NullableContext(0)]
		public class EComponentDefine
		{
			// Token: 0x04037B78 RID: 228216
			public const int CaptionItem = 0;

			// Token: 0x04037B79 RID: 228217
			public const int LeftMultiTemplateScrollView = 1;

			// Token: 0x04037B7A RID: 228218
			public const int LeftScrollItem = 2;

			// Token: 0x04037B7B RID: 228219
			public const int SortItem = 3;

			// Token: 0x04037B7C RID: 228220
			public const int ComposeLevelBtn = 4;

			// Token: 0x04037B7D RID: 228221
			public const int DragRootItem = 5;

			// Token: 0x04037B7E RID: 228222
			public const int DragItemNameText = 6;

			// Token: 0x04037B7F RID: 228223
			public const int DragComponent = 7;

			// Token: 0x04037B80 RID: 228224
			public const int DragItem = 8;

			// Token: 0x04037B81 RID: 228225
			public const int ItemDesRootItem = 9;

			// Token: 0x04037B82 RID: 228226
			public const int ItemDesQualitySprint = 10;

			// Token: 0x04037B83 RID: 228227
			public const int ItemDesTexture = 11;

			// Token: 0x04037B84 RID: 228228
			public const int ItemDesNumText = 12;

			// Token: 0x04037B85 RID: 228229
			public const int ItemDesNameText = 13;

			// Token: 0x04037B86 RID: 228230
			public const int ItemDesSubTitleText = 14;

			// Token: 0x04037B87 RID: 228231
			public const int ItemDesMainText = 15;

			// Token: 0x04037B88 RID: 228232
			public const int BottomLockItem = 16;

			// Token: 0x04037B89 RID: 228233
			public const int BottomScrollView = 17;

			// Token: 0x04037B8A RID: 228234
			public const int BottomScrollItem = 18;

			// Token: 0x04037B8B RID: 228235
			public const int BottomAddItem = 19;

			// Token: 0x04037B8C RID: 228236
			public const int BottomDesText = 20;

			// Token: 0x04037B8D RID: 228237
			public const int BottomLeftText = 21;

			// Token: 0x04037B8E RID: 228238
			public const int BottomMidText = 22;

			// Token: 0x04037B8F RID: 228239
			public const int BottomTimeText = 23;

			// Token: 0x04037B90 RID: 228240
			public const int ConfirmBtn = 24;

			// Token: 0x04037B91 RID: 228241
			public const int LockItem = 25;

			// Token: 0x04037B92 RID: 228242
			public const int LeftPopItem = 26;

			// Token: 0x04037B93 RID: 228243
			public const int LeftPopItemCloseBtn = 27;

			// Token: 0x04037B94 RID: 228244
			public const int LeftPopItemScrollView = 28;

			// Token: 0x04037B95 RID: 228245
			public const int LeftPopItemScrollItem = 29;

			// Token: 0x04037B96 RID: 228246
			public const int MakeCountText = 30;

			// Token: 0x04037B97 RID: 228247
			public const int CostTxt = 31;

			// Token: 0x04037B98 RID: 228248
			public const int CostIconTexture = 32;

			// Token: 0x04037B99 RID: 228249
			public const int FilterItem = 33;

			// Token: 0x04037B9A RID: 228250
			public const int RedDotItem = 34;

			// Token: 0x04037B9B RID: 228251
			public const int ComposeLevelSprite = 35;

			// Token: 0x04037B9C RID: 228252
			public const int StarLayout = 36;

			// Token: 0x04037B9D RID: 228253
			public const int BottomTextRootItem = 37;

			// Token: 0x04037B9E RID: 228254
			public const int TxtActivate = 38;

			// Token: 0x04037B9F RID: 228255
			public const int DragLeftItem = 39;

			// Token: 0x04037BA0 RID: 228256
			public const int DragRightItem = 40;

			// Token: 0x04037BA1 RID: 228257
			public const int DragContentItem = 41;

			// Token: 0x04037BA2 RID: 228258
			public const int SprCheck = 42;

			// Token: 0x04037BA3 RID: 228259
			public const int TxtTips = 43;

			// Token: 0x04037BA4 RID: 228260
			public const int PnlTitle = 44;

			// Token: 0x04037BA5 RID: 228261
			public const int TxtTitle = 45;
		}
	}
}
