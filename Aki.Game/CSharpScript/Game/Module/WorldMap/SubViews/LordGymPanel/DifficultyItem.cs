using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x02003740 RID: 14144
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DifficultyItem : GridProxyAbstract<IDifficultyItemData>
	{
		// Token: 0x06024C84 RID: 150660 RVA: 0x00A63C14 File Offset: 0x00A61E14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024C85 RID: 150661 RVA: 0x00A63D04 File Offset: 0x00A61F04
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUILayoutBase horizontalLayout = base.GetHorizontalLayout(4);
			Func<LordGymDifficultyStateItem> gridProxyCreateFunction = new Func<LordGymDifficultyStateItem>(this.CreateStateItem);
			UUIItem item2 = base.GetItem(5);
			this.StateLayout = new GenericLayout<LordGymDifficultyStateItem, ELordGymDifficultyState>(horizontalLayout, gridProxyCreateFunction, ((item2 != null) ? item2.GetOwner() : null) as AUIBaseActor, false, true);
		}

		// Token: 0x06024C86 RID: 150662 RVA: 0x00A63D5C File Offset: 0x00A61F5C
		private LordGymDifficultyStateItem CreateStateItem()
		{
			return new LordGymDifficultyStateItem();
		}

		// Token: 0x06024C87 RID: 150663 RVA: 0x00A63D64 File Offset: 0x00A61F64
		public override void Refresh(IDifficultyItemData data, bool isSelected, int gridIndex)
		{
			if (data.NameTextArg != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.NameTextId, data.NameTextArg);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.NameTextId, Array.Empty<object>());
			}
			GenericLayout<LordGymDifficultyStateItem, ELordGymDifficultyState> stateLayout = this.StateLayout;
			if (stateLayout == null)
			{
				return;
			}
			stateLayout.RefreshByData(data.StateList, null, false);
		}

		// Token: 0x06024C88 RID: 150664 RVA: 0x00A63DCC File Offset: 0x00A61FCC
		public override object GetKey(IDifficultyItemData data, int gridIndex)
		{
			return base.GridIndex;
		}

		// Token: 0x04014689 RID: 83593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<LordGymDifficultyStateItem, ELordGymDifficultyState> StateLayout;
	}
}
