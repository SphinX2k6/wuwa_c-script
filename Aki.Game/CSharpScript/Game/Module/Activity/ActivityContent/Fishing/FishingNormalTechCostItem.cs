using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006620 RID: 26144
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingNormalTechCostItem : GridProxyAbstract<int>
	{
		// Token: 0x060418BD RID: 268477 RVA: 0x00FE45CC File Offset: 0x00FE27CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060418BE RID: 268478 RVA: 0x00FE46B4 File Offset: 0x00FE28B4
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x060418BF RID: 268479 RVA: 0x00FE46BC File Offset: 0x00FE28BC
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060418C0 RID: 268480 RVA: 0x00FE46C4 File Offset: 0x00FE28C4
		private void AddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
		}

		// Token: 0x060418C1 RID: 268481 RVA: 0x00FE4728 File Offset: 0x00FE2928
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
			EventSystem.Instance.Remove(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
		}

		// Token: 0x060418C2 RID: 268482 RVA: 0x00FE478C File Offset: 0x00FE298C
		private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
		{
			foreach (IProto_NormalItem proto_NormalItem in normalItemList)
			{
				if (this.ItemId == proto_NormalItem.Id)
				{
					this.RefreshCountText();
					break;
				}
			}
		}

		// Token: 0x060418C3 RID: 268483 RVA: 0x00FE47E4 File Offset: 0x00FE29E4
		private void OnRemoveCommonItem(IReadOnlyList<int> configId)
		{
			if (!configId.Contains(this.ItemId))
			{
				return;
			}
			this.RefreshCountText();
		}

		// Token: 0x060418C4 RID: 268484 RVA: 0x00FE47FB File Offset: 0x00FE29FB
		private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (this.ItemId != normalItem.Id)
			{
				return;
			}
			this.RefreshCountText();
		}

		// Token: 0x060418C5 RID: 268485 RVA: 0x00FE4814 File Offset: 0x00FE2A14
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ItemId = data;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data);
			if (itemConfigData == null)
			{
				return;
			}
			base.SetTextureByPath(itemConfigData.IconSmall, base.GetTexture(2), null, null);
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060418C6 RID: 268486 RVA: 0x00FE488C File Offset: 0x00FE2A8C
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060418C7 RID: 268487 RVA: 0x00FE48D0 File Offset: 0x00FE2AD0
		private void OnClickBtn()
		{
			if (this.ItemId != 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
			}
		}

		// Token: 0x040221A5 RID: 139685
		private int ItemId;

		// Token: 0x0200C837 RID: 51255
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C796 RID: 247702
			public const int Btn = 0;

			// Token: 0x0403C797 RID: 247703
			public const int TipsText = 1;

			// Token: 0x0403C798 RID: 247704
			public const int IconTexture = 2;

			// Token: 0x0403C799 RID: 247705
			public const int CostText = 3;
		}
	}
}
