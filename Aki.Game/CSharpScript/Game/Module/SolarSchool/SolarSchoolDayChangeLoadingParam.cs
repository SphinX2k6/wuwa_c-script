using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A16 RID: 23062
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolDayChangeLoadingParam
	{
		// Token: 0x0401DE52 RID: 122450
		[Nullable(1)]
		public string SequenceName = string.Empty;

		// Token: 0x0401DE53 RID: 122451
		public int StartDayIndex;

		// Token: 0x0401DE54 RID: 122452
		public int TargetDayIndex;

		// Token: 0x0401DE55 RID: 122453
		public Action DateChangeCallback;

		// Token: 0x0401DE56 RID: 122454
		public Action CoverReadyCallback;
	}
}
