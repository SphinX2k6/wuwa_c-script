using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A2C RID: 23084
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolLocationChangeLoadingParam
	{
		// Token: 0x0401DEAE RID: 122542
		public AvgLocationChange Config;

		// Token: 0x0401DEAF RID: 122543
		public SolarSchoolVisualNovelTransition Transition;

		// Token: 0x0401DEB0 RID: 122544
		public Action CoveredCallback;
	}
}
