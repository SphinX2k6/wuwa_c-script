using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005047 RID: 20551
	[NullableContext(1)]
	[Nullable(0)]
	public class SubtitleConfigProxy
	{
		// Token: 0x0401C078 RID: 114808
		public float StartTime;

		// Token: 0x0401C079 RID: 114809
		public float EndTime;

		// Token: 0x0401C07A RID: 114810
		public string OriginSubtitleId = "";

		// Token: 0x0401C07B RID: 114811
		public string TranslationSubtitleId = "";

		// Token: 0x0401C07C RID: 114812
		public bool HideOrigin;
	}
}
