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
	// Token: 0x02005FBD RID: 24509
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingCabinItem : UiPanelBase
	{
		// Token: 0x0603AE5B RID: 241243 RVA: 0x010A48F0 File Offset: 0x010A2AF0
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

		// Token: 0x0603AE5C RID: 241244 RVA: 0x010A49B7 File Offset: 0x010A2BB7
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<GridItem, int>(base.GetGridLayout(1), new Func<GridItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0603AE5D RID: 241245 RVA: 0x010A49DA File Offset: 0x010A2BDA
		private GridItem CreateItem()
		{
			return new GridItem();
		}

		// Token: 0x0603AE5E RID: 241246 RVA: 0x010A49E1 File Offset: 0x010A2BE1
		protected override void OnBeforeDestroy()
		{
			this.ButtonFunction = null;
		}

		// Token: 0x0603AE5F RID: 241247 RVA: 0x010A49EA File Offset: 0x010A2BEA
		private void ButtonClick()
		{
			Action buttonFunction = this.ButtonFunction;
			if (buttonFunction == null)
			{
				return;
			}
			buttonFunction();
		}

		// Token: 0x0603AE60 RID: 241248 RVA: 0x010A49FC File Offset: 0x010A2BFC
		public void SetFunction(Action buttonFunction)
		{
			this.ButtonFunction = buttonFunction;
		}

		// Token: 0x0603AE61 RID: 241249 RVA: 0x010A4A08 File Offset: 0x010A2C08
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

		// Token: 0x0401EF6B RID: 126827
		protected GenericLayout<GridItem, int> Layout;

		// Token: 0x0401EF6C RID: 126828
		[Nullable(2)]
		private Action ButtonFunction;

		// Token: 0x0200B8DE RID: 47326
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040390EF RID: 233711
			public const int Button = 0;

			// Token: 0x040390F0 RID: 233712
			public const int LayoutGridList = 1;

			// Token: 0x040390F1 RID: 233713
			public const int GridItem = 2;
		}
	}
}
