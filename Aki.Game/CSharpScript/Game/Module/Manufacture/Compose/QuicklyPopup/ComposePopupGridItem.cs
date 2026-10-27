using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005677 RID: 22135
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ComposePopupGridItem : GridProxyAbstract<IComposePopupGridItemData>
	{
		// Token: 0x06038556 RID: 230742 RVA: 0x00D5E0C8 File Offset: 0x00D5C2C8
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

		// Token: 0x06038557 RID: 230743 RVA: 0x00D5E2E8 File Offset: 0x00D5C4E8
		protected override UniTask OnBeforeStartAsync()
		{
			ComposePopupGridItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposePopupGridItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038558 RID: 230744 RVA: 0x00D5E32C File Offset: 0x00D5C52C
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

		// Token: 0x06038559 RID: 230745 RVA: 0x00D5E3B0 File Offset: 0x00D5C5B0
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

		// Token: 0x0603855A RID: 230746 RVA: 0x00D5E4D4 File Offset: 0x00D5C6D4
		private void RefreshByState(EGridState state)
		{
			bool uiactive = state == EGridState.Enough;
			bool flag = state != EGridState.Enough && state != EGridState.NotEnough;
			bool uiactive2 = state == EGridState.NotEnough;
			bool flag2 = state == EGridState.Purification || state == EGridState.Exchange || state == EGridState.NotEnough;
			bool flag3 = state == EGridState.Purification;
			UUIItem item6 = base.GetItem(0);
			if (item6 != null)
			{
				item6.SetUIActive(uiactive);
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
					List<ISelectedData> composeList = this.CachedData.ComposeList;
					bool flag4;
					if (composeList == null)
					{
						flag4 = false;
					}
					else
					{
						flag4 = composeList.Any(delegate(ISelectedData item)
						{
							CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(item.ItemId);
							return itemConfigData != null && itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Gift;
						});
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

		// Token: 0x0603855B RID: 230747 RVA: 0x00D5E7AC File Offset: 0x00D5C9AC
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

		// Token: 0x0603855C RID: 230748 RVA: 0x00D5E858 File Offset: 0x00D5CA58
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

		// Token: 0x0603855D RID: 230749 RVA: 0x00D5E8B0 File Offset: 0x00D5CAB0
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

		// Token: 0x0603855E RID: 230750 RVA: 0x00D5E922 File Offset: 0x00D5CB22
		private ComposePopupScrollItemGrid CreateItemScrollGrid()
		{
			return new ComposePopupScrollItemGrid
			{
				OnToggleCallback = new Action<ISelectedData>(this.OpenItemTipsBySelectedData)
			};
		}

		// Token: 0x0603855F RID: 230751 RVA: 0x00D5E93C File Offset: 0x00D5CB3C
		private void OpenItemTipsBySelectedData(ISelectedData selectedData)
		{
			ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null);
			ComposeModel.Instance.ComposeSelectItem = selectedData;
			ComposeModel.Instance.ComposeSkipSourceView = this.BelongView;
			InventoryModel.Instance.SetItemNeedCount(new int?(selectedData.Count - selectedData.SelectedCount));
		}

		// Token: 0x06038560 RID: 230752 RVA: 0x00D5E994 File Offset: 0x00D5CB94
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

		// Token: 0x06038561 RID: 230753 RVA: 0x00D5EBA4 File Offset: 0x00D5CDA4
		private void PlayNiagara()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(14);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(true);
		}

		// Token: 0x06038562 RID: 230754 RVA: 0x00D5EBB9 File Offset: 0x00D5CDB9
		public void StopNiagara()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(14);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0401D9B3 RID: 121267
		public const int ITEM_INVALID_ID = -1;

		// Token: 0x0401D9B4 RID: 121268
		[Nullable(2)]
		private ComposePopupMediumItemGrid ItemGrid;

		// Token: 0x0401D9B5 RID: 121269
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<ComposePopupScrollItemGrid, ISelectedData> ConsumeItemScroll;

		// Token: 0x0401D9B6 RID: 121270
		[Nullable(2)]
		private ButtonItem PurificationButton;

		// Token: 0x0401D9B7 RID: 121271
		[Nullable(2)]
		private ButtonItem NormalConfirmButton;

		// Token: 0x0401D9B8 RID: 121272
		[Nullable(2)]
		private IComposePopupGridItemData CachedData;

		// Token: 0x0401D9B9 RID: 121273
		private int CachedGetWayId;

		// Token: 0x0401D9BA RID: 121274
		public EUiViewName? BelongView;

		// Token: 0x0200B841 RID: 47169
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04037C55 RID: 228437
			BgEnough,
			// Token: 0x04037C56 RID: 228438
			TxtEnough,
			// Token: 0x04037C57 RID: 228439
			ItemScroll,
			// Token: 0x04037C58 RID: 228440
			Content,
			// Token: 0x04037C59 RID: 228441
			ItemGridL,
			// Token: 0x04037C5A RID: 228442
			TxtTips,
			// Token: 0x04037C5B RID: 228443
			Arrow,
			// Token: 0x04037C5C RID: 228444
			ItemGridR,
			// Token: 0x04037C5D RID: 228445
			PanelRight,
			// Token: 0x04037C5E RID: 228446
			BtnConfirmR,
			// Token: 0x04037C5F RID: 228447
			BtnSecConfirmR,
			// Token: 0x04037C60 RID: 228448
			Checked,
			// Token: 0x04037C61 RID: 228449
			Line,
			// Token: 0x04037C62 RID: 228450
			PnlNotEnough,
			// Token: 0x04037C63 RID: 228451
			Niagara
		}
	}
}
