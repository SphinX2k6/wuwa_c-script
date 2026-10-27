using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E3C RID: 28220
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingCabinItem : UiPanelBase
	{
		// Token: 0x06044CCE RID: 281806 RVA: 0x010FA370 File Offset: 0x010F8570
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06044CCF RID: 281807 RVA: 0x010FA437 File Offset: 0x010F8637
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<GridItem, int>(base.GetGridLayout(1), new Func<GridItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x06044CD0 RID: 281808 RVA: 0x010FA45A File Offset: 0x010F865A
		private GridItem CreateItem()
		{
			return new GridItem();
		}

		// Token: 0x06044CD1 RID: 281809 RVA: 0x010FA461 File Offset: 0x010F8661
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x06044CD2 RID: 281810 RVA: 0x010FA46A File Offset: 0x010F866A
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x06044CD3 RID: 281811 RVA: 0x010FA47C File Offset: 0x010F867C
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x06044CD4 RID: 281812 RVA: 0x010FA488 File Offset: 0x010F8688
		public void RefreshCabin()
		{
			List<List<int>> backpackPosDataDoublyList = DockyardModel.Instance.BackpackPosDataDoublyList;
			List<int> list = new List<int>();
			foreach (List<int> collection in backpackPosDataDoublyList)
			{
				list.AddRange(collection);
			}
			this.Layout.RefreshByData(list, null, false);
		}

		// Token: 0x04023CB6 RID: 146614
		protected GenericLayout<GridItem, int> Layout;

		// Token: 0x04023CB7 RID: 146615
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200CCEE RID: 52462
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403DCCD RID: 253133
			public const int Button = 0;

			// Token: 0x0403DCCE RID: 253134
			public const int LayoutGridList = 1;

			// Token: 0x0403DCCF RID: 253135
			public const int GridItem = 2;
		}
	}
}
