using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005080 RID: 20608
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextWriterComponentContext
	{
		// Token: 0x17008067 RID: 32871
		// (get) Token: 0x06034CCD RID: 216269 RVA: 0x00C7DB15 File Offset: 0x00C7BD15
		// (set) Token: 0x06034CCE RID: 216270 RVA: 0x00C7DB1D File Offset: 0x00C7BD1D
		public UUIText TextComponent { get; set; }

		// Token: 0x17008068 RID: 32872
		// (get) Token: 0x06034CCF RID: 216271 RVA: 0x00C7DB26 File Offset: 0x00C7BD26
		// (set) Token: 0x06034CD0 RID: 216272 RVA: 0x00C7DB2E File Offset: 0x00C7BD2E
		public UUIEffectTextAnimation TextAnimComp { get; set; }

		// Token: 0x17008069 RID: 32873
		// (get) Token: 0x06034CD1 RID: 216273 RVA: 0x00C7DB37 File Offset: 0x00C7BD37
		// (set) Token: 0x06034CD2 RID: 216274 RVA: 0x00C7DB3F File Offset: 0x00C7BD3F
		public ULGUIPlayTweenComponent TweenComp { get; set; }

		// Token: 0x1700806A RID: 32874
		// (get) Token: 0x06034CD3 RID: 216275 RVA: 0x00C7DB48 File Offset: 0x00C7BD48
		// (set) Token: 0x06034CD4 RID: 216276 RVA: 0x00C7DB50 File Offset: 0x00C7BD50
		public Action OnAnimCompleteDelegate { get; set; }

		// Token: 0x1700806B RID: 32875
		// (get) Token: 0x06034CD5 RID: 216277 RVA: 0x00C7DB59 File Offset: 0x00C7BD59
		// (set) Token: 0x06034CD6 RID: 216278 RVA: 0x00C7DB61 File Offset: 0x00C7BD61
		public Action OnStopDelegate { get; set; }
	}
}
