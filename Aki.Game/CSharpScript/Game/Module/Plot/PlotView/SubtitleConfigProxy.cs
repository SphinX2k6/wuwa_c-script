using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004016 RID: 16406
	[NullableContext(1)]
	[Nullable(0)]
	public class SubtitleConfigProxy
	{
		// Token: 0x04016A9B RID: 92827
		public float StartTime;

		// Token: 0x04016A9C RID: 92828
		public float EndTime;

		// Token: 0x04016A9D RID: 92829
		public string OriginSubtitleId = "";

		// Token: 0x04016A9E RID: 92830
		public string TranslationSubtitleId = "";

		// Token: 0x04016A9F RID: 92831
		public bool HideOrigin;
	}
}
