using System;
using System.Collections.Generic;
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
	// Token: 0x0200559E RID: 21918
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingNormalTechCostItem : GridProxyAbstract<int>
	{
		// Token: 0x06036582 RID: 222594 RVA: 0x00F2B63C File Offset: 0x00F2983C
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

		// Token: 0x06036583 RID: 222595 RVA: 0x00F2B724 File Offset: 0x00F29924
		protected override void OnStart()
		{
			this.AddEventListener();
		}

		// Token: 0x06036584 RID: 222596 RVA: 0x00F2B72C File Offset: 0x00F2992C
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x06036585 RID: 222597 RVA: 0x00F2B734 File Offset: 0x00F29934
		private void AddEventListener()
		{
			EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
			EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
		}

		// Token: 0x06036586 RID: 222598 RVA: 0x00F2B798 File Offset: 0x00F29998
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
			EventSystem.Instance.Remove(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
		}

		// Token: 0x06036587 RID: 222599 RVA: 0x00F2B7FC File Offset: 0x00F299FC
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

		// Token: 0x06036588 RID: 222600 RVA: 0x00F2B854 File Offset: 0x00F29A54
		private void OnRemoveCommonItem(IReadOnlyList<int> configId)
		{
			bool flag = false;
			using (IEnumerator<int> enumerator = configId.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == this.ItemId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return;
			}
			this.RefreshCountText();
		}

		// Token: 0x06036589 RID: 222601 RVA: 0x00F2B8AC File Offset: 0x00F29AAC
		private void OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (this.ItemId != normalItem.Id)
			{
				return;
			}
			this.RefreshCountText();
		}

		// Token: 0x0603658A RID: 222602 RVA: 0x00F2B8C4 File Offset: 0x00F29AC4
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

		// Token: 0x0603658B RID: 222603 RVA: 0x00F2B93C File Offset: 0x00F29B3C
		private void RefreshCountText()
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.ItemId, 0);
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(itemCountByConfigId);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0603658C RID: 222604 RVA: 0x00F2B980 File Offset: 0x00F29B80
		private void OnClickBtn()
		{
			if (this.ItemId != 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
			}
		}

		// Token: 0x0401CAD6 RID: 117462
		private int ItemId;

		// Token: 0x0200B219 RID: 45593
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040370DB RID: 225499
			public const int Btn = 0;

			// Token: 0x040370DC RID: 225500
			public const int TipsText = 1;

			// Token: 0x040370DD RID: 225501
			public const int IconTexture = 2;

			// Token: 0x040370DE RID: 225502
			public const int CostText = 3;
		}
	}
}
