using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x02003FD9 RID: 16345
	public class PlotTipsView : PlotTipsViewBase
	{
		// Token: 0x060295B9 RID: 169401 RVA: 0x00BA5027 File Offset: 0x00BA3227
		public PlotTipsView()
		{
			this.ResourceId = "UiView_MascotTips";
		}

		// Token: 0x060295BA RID: 169402 RVA: 0x00BA503C File Offset: 0x00BA323C
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

		// Token: 0x060295BB RID: 169403 RVA: 0x00BA50A5 File Offset: 0x00BA32A5
		protected override void OnInit()
		{
			this.IconItem = base.GetTexture(0);
			this.SubtitleItem = base.GetText(1);
		}

		// Token: 0x02009B7A RID: 39802
		private static class EChildCom
		{
			// Token: 0x040306E8 RID: 198376
			public const int Icon = 0;

			// Token: 0x040306E9 RID: 198377
			public const int Text = 1;
		}
	}
}
