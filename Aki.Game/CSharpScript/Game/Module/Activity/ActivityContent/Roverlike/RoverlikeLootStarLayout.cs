using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200616D RID: 24941
	internal class RoverlikeLootStarLayout : UiPanelBase
	{
		// Token: 0x0603F0BC RID: 258236 RVA: 0x00F3C254 File Offset: 0x00F3A454
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F0BD RID: 258237 RVA: 0x00F3C2BD File Offset: 0x00F3A4BD
		protected override void OnStart()
		{
			this.StarGrid = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(0), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603F0BE RID: 258238 RVA: 0x00F3C2F0 File Offset: 0x00F3A4F0
		protected override void OnBeforeDestroy()
		{
			this.StarGrid = null;
		}

		// Token: 0x0603F0BF RID: 258239 RVA: 0x00F3C2F9 File Offset: 0x00F3A4F9
		public void SetVisible(bool visible)
		{
			base.SetUiActive(visible);
		}

		// Token: 0x0603F0C0 RID: 258240 RVA: 0x00F3C304 File Offset: 0x00F3A504
		public void SetStars(int level, int maxLevel)
		{
			List<bool> list = new List<bool>();
			for (int i = 0; i < maxLevel; i++)
			{
				list.Add(i < level);
			}
			GenericLayout<RoverlikeLootStarItem, bool> starGrid = this.StarGrid;
			if (starGrid == null)
			{
				return;
			}
			starGrid.RefreshByData(list, null, false);
		}

		// Token: 0x0603F0C1 RID: 258241 RVA: 0x00F3C340 File Offset: 0x00F3A540
		[NullableContext(1)]
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x04020E26 RID: 134694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarGrid;

		// Token: 0x0200C3D4 RID: 50132
		private class ERoverlikeLootStarLayout
		{
			// Token: 0x0403B17B RID: 242043
			public const int StarLayout = 0;

			// Token: 0x0403B17C RID: 242044
			public const int StarItem = 1;
		}
	}
}
