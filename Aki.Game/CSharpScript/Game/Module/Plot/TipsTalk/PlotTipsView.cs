using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x0200500F RID: 20495
	public class PlotTipsView : PlotTipsViewBase
	{
		// Token: 0x06034716 RID: 214806 RVA: 0x00C59B27 File Offset: 0x00C57D27
		public PlotTipsView()
		{
			this.ResourceId = "UiView_MascotTips";
		}

		// Token: 0x06034717 RID: 214807 RVA: 0x00C59B3C File Offset: 0x00C57D3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034718 RID: 214808 RVA: 0x00C59BA5 File Offset: 0x00C57DA5
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(0);
			this.SubtitleItem = base.GetText(1);
		}

		// Token: 0x0200B142 RID: 45378
		private static class EChildCom
		{
			// Token: 0x04035CA0 RID: 220320
			public const int Icon = 0;

			// Token: 0x04035CA1 RID: 220321
			public const int Text = 1;
		}
	}
}
