using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050EB RID: 20715
	internal class RoverlikeLootStarLayout : UiPanelBase
	{
		// Token: 0x06033D7C RID: 212348 RVA: 0x00E83128 File Offset: 0x00E81328
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

		// Token: 0x06033D7D RID: 212349 RVA: 0x00E83191 File Offset: 0x00E81391
		protected override void OnStart()
		{
			this.StarGrid = new GenericLayout<RoverlikeLootStarItem, bool>(base.GetHorizontalLayout(0), new Func<RoverlikeLootStarItem>(this.CreateStarItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06033D7E RID: 212350 RVA: 0x00E831C4 File Offset: 0x00E813C4
		protected override void OnBeforeDestroy()
		{
			this.StarGrid = null;
		}

		// Token: 0x06033D7F RID: 212351 RVA: 0x00E831CD File Offset: 0x00E813CD
		public void SetVisible(bool visible)
		{
			base.SetUiActive(visible);
		}

		// Token: 0x06033D80 RID: 212352 RVA: 0x00E831D8 File Offset: 0x00E813D8
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

		// Token: 0x06033D81 RID: 212353 RVA: 0x00E83214 File Offset: 0x00E81414
		[NullableContext(1)]
		private RoverlikeLootStarItem CreateStarItem()
		{
			return new RoverlikeLootStarItem();
		}

		// Token: 0x0401B753 RID: 112467
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RoverlikeLootStarItem, bool> StarGrid;

		// Token: 0x0200ADBB RID: 44475
		private class ERoverlikeLootStarLayout
		{
			// Token: 0x04035ADC RID: 219868
			public const int StarLayout = 0;

			// Token: 0x04035ADD RID: 219869
			public const int StarItem = 1;
		}
	}
}
