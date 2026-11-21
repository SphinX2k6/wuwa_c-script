using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common.TipList
{
	// Token: 0x0200376C RID: 14188
	public class WorldMapSecondaryTipListPanel : UiPanelBase
	{
		// Token: 0x06024E0A RID: 151050 RVA: 0x00A6B7AC File Offset: 0x00A699AC
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

		// Token: 0x06024E0B RID: 151051 RVA: 0x00A6B818 File Offset: 0x00A69A18
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(0);
			this.TipsLayout = new GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam>(verticalLayout, new Func<WorldMapSecondaryTipListItem>(this.CreateListItem), null, false, true);
		}

		// Token: 0x06024E0C RID: 151052 RVA: 0x00A6B849 File Offset: 0x00A69A49
		[NullableContext(1)]
		protected virtual WorldMapSecondaryTipListItem CreateListItem()
		{
			return new WorldMapSecondaryTipListItem();
		}

		// Token: 0x06024E0D RID: 151053 RVA: 0x00A6B850 File Offset: 0x00A69A50
		protected override void OnBeforeDestroy()
		{
			GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam> tipsLayout = this.TipsLayout;
			if (tipsLayout == null)
			{
				return;
			}
			tipsLayout.ClearChildren();
		}

		// Token: 0x06024E0E RID: 151054 RVA: 0x00A6B862 File Offset: 0x00A69A62
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

		// Token: 0x040146FB RID: 83707
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<WorldMapSecondaryTipListItem, IWorldMapSecondaryTipItemParam> TipsLayout;

		// Token: 0x020094C2 RID: 38082
		public static class EComponents
		{
			// Token: 0x0402E761 RID: 190305
			public const int PnlMapTipsListItemA = 0;

			// Token: 0x0402E762 RID: 190306
			public const int PnlList = 1;
		}
	}
}
