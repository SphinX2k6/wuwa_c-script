using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x0200483B RID: 18491
	public class WorldMapSecondaryTipListPanel : UiPanelBase
	{
		// Token: 0x0603063A RID: 198202 RVA: 0x00B3B6E0 File Offset: 0x00B398E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603063B RID: 198203 RVA: 0x00B3B74C File Offset: 0x00B3994C
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(0);
			this.TipsLayout = new GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam>(verticalLayout, new Func<WorldMapSecondaryTipListItem>(this.CreateListItem), null, false, true);
		}

		// Token: 0x0603063C RID: 198204 RVA: 0x00B3B77D File Offset: 0x00B3997D
		[NullableContext(1)]
		protected virtual WorldMapSecondaryTipListItem CreateListItem()
		{
			return new WorldMapSecondaryTipListItem();
		}

		// Token: 0x0603063D RID: 198205 RVA: 0x00B3B784 File Offset: 0x00B39984
		protected override void OnBeforeDestroy()
		{
			GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam> tipsLayout = this.TipsLayout;
			if (tipsLayout == null)
			{
				return;
			}
			tipsLayout.ClearChildren();
		}

		// Token: 0x0603063E RID: 198206 RVA: 0x00B3B796 File Offset: 0x00B39996
		[NullableContext(1)]
		public void RefreshByData(List<IWorldMapSecondaryTipItemParam> data)
		{
			GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam> tipsLayout = this.TipsLayout;
			if (tipsLayout == null)
			{
				return;
			}
			tipsLayout.RefreshByData(data, null, false);
		}

		// Token: 0x0401A047 RID: 106567
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam> TipsLayout;

		// Token: 0x0200AB13 RID: 43795
		public static class EComponents
		{
			// Token: 0x04033FE1 RID: 212961
			public const int PnlMapTipsListItemA = 0;

			// Token: 0x04033FE2 RID: 212962
			public const int PnlList = 1;
		}
	}
}
