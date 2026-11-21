using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Compose.QuicklyPopup
{
	// Token: 0x0200464D RID: 17997
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposePopupGridItem : GridProxyAbstract<IComposePopupGridItemData>
	{
		// Token: 0x0602D453 RID: 185427 RVA: 0x00CAC1C8 File Offset: 0x00CAA3C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602D454 RID: 185428 RVA: 0x00CAC3E8 File Offset: 0x00CAA5E8
		protected override UniTask OnBeforeStartAsync()
		{
			ComposePopupGridItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposePopupGridItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D455 RID: 185429 RVA: 0x00CAC42C File Offset: 0x00CAA62C
		protected override void OnStart()
		{
			ComposePopupMediumItemGrid itemGrid = this.ItemGrid;
			if (itemGrid != null)
			{
				itemGrid.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
			}
			this.ItemGrid.UseSelectedCoin = false;
			ButtonItem purificationButton = this.PurificationButton;
			if (purificationButton != null)
			{
				purificationButton.SetFunction(new Action<int>(this.OnClickConfirm));
			}
			ButtonItem normalConfirmButton = this.NormalConfirmButton;
			if (normalConfirmButton == null)
			{
				return;
			}
			normalConfirmButton.SetFunction(new Action<int>(this.OnClickConfirm));
		}

		// Token: 0x0602D456 RID: 185430 RVA: 0x00CAC4B0 File Offset: 0x00CAA6B0
		public override void Refresh(IComposePopupGridItemData data, bool isSelected, int gridIndex)
		{
			IComposePopupGridItemData cachedData = this.CachedData;
			int? num = (cachedData != null) ? new int?(cachedData.Item.ItemId) : null;
			int itemId = data.Item.ItemId;
			if (!(num.GetValueOrDefault() == itemId & num != null))
			{
				this.StopNiagara();
			}
			this.CachedData = data;
			this.RefreshByState(data.State);
			this.RefreshMainItem(data.Item);
			if (data.ComposeList != null)
			{
				List<ISelectedData> list = null;
				if (data.Item.ItemId == 2)
				{
					list = new List<ISelectedData>();
					list.Add(data.Item);
					using (List<ISelectedData>.Enumerator enumerator = data.ComposeList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ISelectedData item = enumerator.Current;
							if (list != null)
							{
								list.Add(item);
							}
						}
						goto IL_DA;
					}
				}
				list = data.ComposeList;
				IL_DA:
				if (data.State == EGridState.Purification || data.State == EGridState.Exchange)
				{
					this.RefreshItemScroll(list);
					return;
				}
				GenericScrollViewNew<ComposePopupScrollItemGrid, ISelectedData> consumeItemScroll = this.ConsumeItemScroll;
				if (consumeItemScroll == null)
				{
					return;
				}
				consumeItemScroll.RefreshByData(list, null, false);
			}
		}

		// Token: 0x0602D457 RID: 185431 RVA: 0x00CAC5D4 File Offset: 0x00CAA7D4
		private void RefreshByState(EGridState state)
		{
			bool uiactive = state == EGridState.Enough;
			bool flag = state != EGridState.Enough && state != EGridState.NotEnough;
			bool uiactive2 = state == EGridState.NotEnough;
			bool flag2 = state == EGridState.Purification || state == EGridState.Exchange || state == EGridState.NotEnough;
			bool flag3 = state == EGridState.Purification;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(flag);
			}
			UUIItem item4 = base.GetItem(12);
			if (item4 != null)
			{
				item4.SetUIActive(flag2);
			}
			UUIItem item5 = base.GetItem(13);
			if (item5 != null)
			{
				item5.SetUIActive(state == EGridState.NotEnough && this.CachedData.Item.ItemId != 2);
			}
			ButtonItem purificationButton = this.PurificationButton;
			if (purificationButton != null)
			{
				purificationButton.SetUiActive(flag3);
			}
			ButtonItem normalConfirmButton = this.NormalConfirmButton;
			if (normalConfirmButton != null)
			{
				normalConfirmButton.SetUiActive(flag2 && !flag3);
			}
			if (flag3)
			{
				string showText;
				SynthesisFormula? synthesisFormula;
				if (this.CachedData.Item.ItemId == 2)
				{
					showText = "AutoSynthesis_GetCellCreditBtn_Text";
				}
				else if (ComposeConfig.Instance.GetSynthesisFormulaByItemId(this.CachedData.Item.ItemId) != null && synthesisFormula.GetValueOrDefault().IsCollect)
				{
					bool flag4 = false;
					if (this.CachedData.ComposeList != null)
					{
						foreach (ISelectedData selectedData in this.CachedData.ComposeList)
						{
							CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(selectedData.ItemId);
							if (itemConfigData != null && itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Gift)
							{
								flag4 = true;
								break;
							}
						}
					}
					showText = (flag4 ? "PrefabTextItem_4115765186_Text" : "GatherCraft_Btn");
				}
				else
				{
					showText = "PrefabTextItem_4115765186_Text";
				}
				ButtonItem purificationButton2 = this.PurificationButton;
				if (purificationButton2 != null)
				{
					purificationButton2.SetShowText(showText);
				}
			}
			else if (flag2)
			{
				string showText2;
				if (state == EGridState.Exchange)
				{
					showText2 = "AutoSynthesis_ConversionBtn_Text";
				}
				else
				{
					showText2 = "AutoSynthesis_TrackBtn_Text";
				}
				ButtonItem normalConfirmButton2 = this.NormalConfirmButton;
				if (normalConfirmButton2 != null)
				{
					normalConfirmButton2.SetShowText(showText2);
				}
			}
			bool uiactive3 = flag;
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(uiactive2);
			}
			if (state == EGridState.NotEnough)
			{
				AccessPath? itemFirstAccessByItemId = this.GetItemFirstAccessByItemId(this.CachedData.Item.ItemId);
				if (itemFirstAccessByItemId == null)
				{
					if (text != null)
					{
						text.ShowTextNew("AutoSynthesis_Track_Tips");
					}
					this.CachedGetWayId = 0;
					return;
				}
				if (this.CachedData.Item.ItemId == 2)
				{
					if (text != null)
					{
						text.ShowTextNew("AutoSynthesis_CellCreditMissing_Tips");
					}
					uiactive3 = true;
					GenericScrollViewNew<ComposePopupScrollItemGrid, ISelectedData> consumeItemScroll = this.ConsumeItemScroll;
					if (consumeItemScroll != null)
					{
						consumeItemScroll.RefreshByData(new <>z__ReadOnlySingleElementList<ISelectedData>(this.CachedData.Item), null, false);
					}
				}
				else if (text != null)
				{
					text.ShowTextNew(itemFirstAccessByItemId.Value.Description);
				}
				this.CachedGetWayId = itemFirstAccessByItemId.Value.Id;
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(2);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			UUIItem uuiitem = scrollViewWithScrollbar.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(uiactive3);
		}

		// Token: 0x0602D458 RID: 185432 RVA: 0x00CAC8FC File Offset: 0x00CAAAFC
		private AccessPath? GetItemFirstAccessByItemId(int itemId)
		{
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			int[] array = (itemConfigData != null) ? itemConfigData.ItemAccess : null;
			if (array == null || array.Length == 0)
			{
				return null;
			}
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("ComposePopupSkipBlackList");
			foreach (int num in array)
			{
				if (intArrayConfig.IndexOf(num) < 0 && SkipInterfaceModel.Instance.CheckAccessPathCondition(num))
				{
					AccessPath? configById = GetWayConfig.Instance.GetConfigById(num);
					if (configById != null && configById.Value.Type != 1)
					{
						return configById;
					}
				}
			}
			return null;
		}

		// Token: 0x0602D459 RID: 185433 RVA: 0x00CAC9A8 File Offset: 0x00CAABA8
		private void RefreshMainItem(ISelectedData selectedData)
		{
			ComposePopupMediumItemGrid itemGrid = this.ItemGrid;
			if (itemGrid != null)
			{
				itemGrid.Refresh(selectedData, false, 0);
			}
			ComposePopupMediumItemGrid itemGrid2 = this.ItemGrid;
			if (itemGrid2 == null)
			{
				return;
			}
			itemGrid2.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
			{
				this.OpenItemTipsBySelectedData(selectedData);
			});
		}

		// Token: 0x0602D45A RID: 185434 RVA: 0x00CACA00 File Offset: 0x00CAAC00
		private void RefreshItemScroll(IList<ISelectedData> data)
		{
			int value = ConfigCommonParamById.GetIntConfig("CraftingMaterialGridNum").Value;
			List<ISelectedData> list = new List<ISelectedData>(data);
			for (int i = data.Count; i < value; i++)
			{
				list.Add(new SelectedData
				{
					ItemId = -1,
					IncId = 0,
					Count = 0,
					SelectedCount = 0
				});
			}
			GenericScrollViewNew<ComposePopupScrollItemGrid, ISelectedData> consumeItemScroll = this.ConsumeItemScroll;
			if (consumeItemScroll == null)
			{
				return;
			}
			consumeItemScroll.RefreshByData(list, null, false);
		}

		// Token: 0x0602D45B RID: 185435 RVA: 0x00CACA72 File Offset: 0x00CAAC72
		private ComposePopupScrollItemGrid CreateItemScrollGrid()
		{
			return new ComposePopupScrollItemGrid
			{
				OnToggleCallback = new Action<ISelectedData>(this.OpenItemTipsBySelectedData)
			};
		}

		// Token: 0x0602D45C RID: 185436 RVA: 0x00CACA8C File Offset: 0x00CAAC8C
		private void OpenItemTipsBySelectedData(ISelectedData selectedData)
		{
			ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null, false);
			ComposeModel.Instance.ComposeSelectItem = selectedData;
			ComposeModel.Instance.ComposeSkipSourceView = this.BelongView;
			InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
		}

		// Token: 0x0602D45D RID: 185437 RVA: 0x00CACAE4 File Offset: 0x00CAACE4
		private void OnClickConfirm(int _)
		{
			if (this.CachedData == null)
			{
				return;
			}
			switch (this.CachedData.State)
			{
			case EGridState.Purification:
			{
				List<SingleItemInfo> list = new List<SingleItemInfo>();
				if (this.CachedData.ComposeList != null)
				{
					foreach (ISelectedData selectedData in this.CachedData.ComposeList)
					{
						list.Add(new SingleItemInfo
						{
							ItemId = selectedData.ItemId,
							ItemNum = selectedData.Count
						});
					}
				}
				int composeCount = this.CachedData.Item.Count - this.CachedData.Item.SelectedCount;
				ComposeController.Instance.SendSynthesisItemRequestNew(this.CachedData.Item.ItemId, composeCount, list, delegate
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("AutoSynthesis_PurificationFinish_Tips", Array.Empty<object>());
				}).Forget();
				this.PlayNiagara();
				return;
			}
			case EGridState.Exchange:
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				if (this.CachedData.ComposeList != null)
				{
					foreach (ISelectedData selectedData2 in this.CachedData.ComposeList)
					{
						dictionary[selectedData2.ItemId] = selectedData2.Count;
					}
				}
				ComposeController.Instance.SendBatchMaterialReplaceRequest(this.CachedData.Item.ItemId, dictionary, delegate
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("AutoSynthesis_SynthesizeFinish_Tips", Array.Empty<object>());
				}).Forget();
				this.PlayNiagara();
				return;
			}
			case EGridState.Enough:
				break;
			case EGridState.NotEnough:
				if (this.CachedGetWayId == 0)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("SkipTask_Prevent", Array.Empty<object>());
					return;
				}
				SkipTaskManager.RunByConfigId(this.CachedGetWayId, this.CachedData.Item.ItemId);
				break;
			default:
				return;
			}
		}

		// Token: 0x0602D45E RID: 185438 RVA: 0x00CACCF4 File Offset: 0x00CAAEF4
		private void PlayNiagara()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(14);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(true);
		}

		// Token: 0x0602D45F RID: 185439 RVA: 0x00CACD09 File Offset: 0x00CAAF09
		public void StopNiagara()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(14);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0401843E RID: 99390
		public const int ITEM_INVALID_ID = -1;

		// Token: 0x0401843F RID: 99391
		[Nullable(2)]
		private ComposePopupMediumItemGrid ItemGrid;

		// Token: 0x04018440 RID: 99392
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ComposePopupScrollItemGrid, ISelectedData> ConsumeItemScroll;

		// Token: 0x04018441 RID: 99393
		[Nullable(2)]
		private ButtonItem PurificationButton;

		// Token: 0x04018442 RID: 99394
		[Nullable(2)]
		private ButtonItem NormalConfirmButton;

		// Token: 0x04018443 RID: 99395
		[Nullable(2)]
		private IComposePopupGridItemData CachedData;

		// Token: 0x04018444 RID: 99396
		private int CachedGetWayId;

		// Token: 0x04018445 RID: 99397
		public EUiViewName? BelongView;

		// Token: 0x0200A269 RID: 41577
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04032673 RID: 206451
			BgEnough,
			// Token: 0x04032674 RID: 206452
			TxtEnough,
			// Token: 0x04032675 RID: 206453
			ItemScroll,
			// Token: 0x04032676 RID: 206454
			Content,
			// Token: 0x04032677 RID: 206455
			ItemGridL,
			// Token: 0x04032678 RID: 206456
			TxtTips,
			// Token: 0x04032679 RID: 206457
			Arrow,
			// Token: 0x0403267A RID: 206458
			ItemGridR,
			// Token: 0x0403267B RID: 206459
			PanelRight,
			// Token: 0x0403267C RID: 206460
			BtnConfirmR,
			// Token: 0x0403267D RID: 206461
			BtnSecConfirmR,
			// Token: 0x0403267E RID: 206462
			Checked,
			// Token: 0x0403267F RID: 206463
			Line,
			// Token: 0x04032680 RID: 206464
			PnlNotEnough,
			// Token: 0x04032681 RID: 206465
			Niagara
		}
	}
}
