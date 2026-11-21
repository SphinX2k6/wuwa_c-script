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
	// Token: 0x02004ADB RID: 19163
	[NullableContext(1)]
	[Nullable(0)]
	public class SvInfo : UiPanelBase
	{
		// Token: 0x0602FEAD RID: 196269 RVA: 0x00D5F000 File Offset: 0x00D5D200
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

		// Token: 0x0602FEAE RID: 196270 RVA: 0x00D5F0F8 File Offset: 0x00D5D2F8
		protected override void OnStart()
		{
			this.InventoryViewComponent = new GenericLayoutNew<MachiningClueItem>(base.GetVerticalLayout(6), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MachiningClueItem>(this.InitMachining), null);
			base.GetText(3).SetUIActive(false);
			this.AddEventListener();
			base.GetItem(1).SetUIActive(false);
			base.GetText(3).SetUIActive(true);
		}

		// Token: 0x0602FEAF RID: 196271 RVA: 0x00D5F151 File Offset: 0x00D5D351
		protected override void OnBeforeDestroy()
		{
			this.InventoryViewComponent = null;
			this.ItemData = null;
			this.RemoveEventListener();
		}

		// Token: 0x0602FEB0 RID: 196272 RVA: 0x00D5F167 File Offset: 0x00D5D367
		private void AddEventListener()
		{
		}

		// Token: 0x0602FEB1 RID: 196273 RVA: 0x00D5F169 File Offset: 0x00D5D369
		private void RemoveEventListener()
		{
		}

		// Token: 0x0602FEB2 RID: 196274 RVA: 0x00D5F16C File Offset: 0x00D5D36C
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

		// Token: 0x0602FEB3 RID: 196275 RVA: 0x00D5F1B8 File Offset: 0x00D5D3B8
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

		// Token: 0x0602FEB4 RID: 196276 RVA: 0x00D5F1E8 File Offset: 0x00D5D3E8
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

		// Token: 0x0602FEB5 RID: 196277 RVA: 0x00D5F2B8 File Offset: 0x00D5D4B8
		private bool CheckDataValid(object itemData)
		{
			if (itemData == null)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.LK, "缺少itemData数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			return true;
		}

		// Token: 0x0602FEB6 RID: 196278 RVA: 0x00D5F2EC File Offset: 0x00D5D4EC
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

		// Token: 0x04019713 RID: 104211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MachiningClueItem> InventoryViewComponent;

		// Token: 0x04019714 RID: 104212
		[Nullable(2)]
		private object ItemData;
	}
}
