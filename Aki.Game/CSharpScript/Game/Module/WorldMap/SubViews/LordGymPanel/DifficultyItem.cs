using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.LordGymPanel
{
	// Token: 0x0200480F RID: 18447
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DifficultyItem : GridProxyAbstract<IDifficultyItemData>
	{
		// Token: 0x060304B4 RID: 197812 RVA: 0x00B33CAC File Offset: 0x00B31EAC
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

		// Token: 0x060304B5 RID: 197813 RVA: 0x00B33D9C File Offset: 0x00B31F9C
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

		// Token: 0x060304B6 RID: 197814 RVA: 0x00B33DF4 File Offset: 0x00B31FF4
		private LordGymDifficultyStateItem CreateStateItem()
		{
			return new LordGymDifficultyStateItem();
		}

		// Token: 0x060304B7 RID: 197815 RVA: 0x00B33DFC File Offset: 0x00B31FFC
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

		// Token: 0x060304B8 RID: 197816 RVA: 0x00B33E64 File Offset: 0x00B32064
		public override object GetKey(IDifficultyItemData data, int gridIndex)
		{
			return base.GridIndex;
		}

		// Token: 0x04019FD5 RID: 106453
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<LordGymDifficultyStateItem, ELordGymDifficultyState> StateLayout;
	}
}
