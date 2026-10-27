using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Cook.View;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AFA RID: 23290
	[NullableContext(1)]
	[Nullable(0)]
	public class SvInfo : UiPanelBase
	{
		// Token: 0x0603AF3B RID: 241467 RVA: 0x00E0E30C File Offset: 0x00E0C50C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x0603AF3C RID: 241468 RVA: 0x00E0E404 File Offset: 0x00E0C604
		protected override void OnStart()
		{
			this.InventoryViewComponent = new GenericLayoutNew<MachiningClueItem>(base.GetVerticalLayout(6), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MachiningClueItem>(this.InitMachining), null);
			base.GetText(3).SetUIActive(false);
			this.AddEventListener();
			base.GetItem(1).SetUIActive(false);
			base.GetText(3).SetUIActive(true);
		}

		// Token: 0x0603AF3D RID: 241469 RVA: 0x00E0E45D File Offset: 0x00E0C65D
		protected override void OnBeforeDestroy()
		{
			this.InventoryViewComponent = null;
			this.ItemData = null;
			this.RemoveEventListener();
		}

		// Token: 0x0603AF3E RID: 241470 RVA: 0x00E0E473 File Offset: 0x00E0C673
		private void AddEventListener()
		{
		}

		// Token: 0x0603AF3F RID: 241471 RVA: 0x00E0E475 File Offset: 0x00E0C675
		private void RemoveEventListener()
		{
		}

		// Token: 0x0603AF40 RID: 241472 RVA: 0x00E0E478 File Offset: 0x00E0C678
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<MachiningClueItem> InitMachining([Nullable(2)] object data, UUIItem uiItem, int index)
		{
			IMachiningClueData machiningClueData = data as IMachiningClueData;
			if (machiningClueData == null)
			{
				return null;
			}
			MachiningClueItem machiningClueItem = new MachiningClueItem(uiItem);
			machiningClueItem.Update(machiningClueData.IsUnlock, machiningClueData.ContentText);
			return new LayoutItem<MachiningClueItem>
			{
				Key = index,
				Value = machiningClueItem
			};
		}

		// Token: 0x0603AF41 RID: 241473 RVA: 0x00E0E4C4 File Offset: 0x00E0C6C4
		[NullableContext(2)]
		public void SetTypeName(string tag = null)
		{
			UUIText text = base.GetText(0);
			if (tag != null)
			{
				text.SetUIActive(true);
				text.SetText(tag, true);
				return;
			}
			text.SetUIActive(false);
		}

		// Token: 0x0603AF42 RID: 241474 RVA: 0x00E0E4F4 File Offset: 0x00E0C6F4
		public void RefreshCooking(ICookingData data, int times)
		{
			if (!this.CheckDataValid(data))
			{
				return;
			}
			if (this.ItemData != null && ((ICookItemData)this.ItemData).ItemId != data.ItemId)
			{
				CookModel.Instance.CurrentCookRoleId = null;
			}
			this.ItemData = data;
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(data.ItemId);
			string itemAttributeDesc = ItemConfig.Instance.GetItemAttributeDesc(data.DataId);
			string newText = string.IsNullOrEmpty(cookFormulaById.FoodBackground) ? "" : CookConfig.Instance.GetLocalText(cookFormulaById.FoodBackground);
			this.InventoryViewComponent.SetActive(false);
			base.GetText(3).SetUIActive(true);
			base.GetText(3).SetText(itemAttributeDesc, true);
			base.GetText(5).SetText(newText, true);
		}

		// Token: 0x0603AF43 RID: 241475 RVA: 0x00E0E5C4 File Offset: 0x00E0C7C4
		private bool CheckDataValid(object itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0603AF44 RID: 241476 RVA: 0x00E0E5F8 File Offset: 0x00E0C7F8
		public void RefreshMachining(IMachiningData data)
		{
			if (!this.CheckDataValid(data))
			{
				return;
			}
			this.ItemData = data;
			this.InventoryViewComponent.SetActive(true);
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(data.ItemId);
			ItemInfo? config = ConfigItemInfoById.GetConfig(cookProcessedById.FinalItemId, true);
			string localText = CookConfig.Instance.GetLocalText(config.Value.BgDescription);
			base.GetText(3).SetUIActive(false);
			base.GetText(5).SetText(localText, true);
			List<IMachiningClueData> list = new List<IMachiningClueData>();
			for (int i = 0; i < cookProcessedById.InterationIdLength; i++)
			{
				int num = cookProcessedById.InterationId(i);
				CookProcessMsg cookProcessMsgById = CookConfig.Instance.GetCookProcessMsgById(num);
				if (data.InteractiveList.Contains(num))
				{
					string localText2 = CookConfig.Instance.GetLocalText(cookProcessMsgById.Introduce);
					list.Add(new MachiningClueData
					{
						IsUnlock = true,
						ContentText = localText2
					});
				}
				else
				{
					string localText3 = CookConfig.Instance.GetLocalText(cookProcessMsgById.Description);
					list.Add(new MachiningClueData
					{
						IsUnlock = false,
						ContentText = localText3
					});
				}
			}
			this.InventoryViewComponent.RebuildLayoutByDataNew<IMachiningClueData>(list, null);
		}

		// Token: 0x0401EC57 RID: 126039
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MachiningClueItem> InventoryViewComponent;

		// Token: 0x0401EC58 RID: 126040
		[Nullable(2)]
		private object ItemData;
	}
}
