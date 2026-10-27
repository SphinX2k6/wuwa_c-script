using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x02007052 RID: 28754
	public class BounceParam
	{
		// Token: 0x04024A17 RID: 150039
		public int? SkillId;

		// Token: 0x04024A18 RID: 150040
		[Nullable(2)]
		public string CurvePath;

		// Token: 0x04024A19 RID: 150041
		public float? Time;

		// Token: 0x04024A1A RID: 150042
		public float? Height;

		// Token: 0x04024A1B RID: 150043
		public bool? UseLocalUp;

		// Token: 0x04024A1C RID: 150044
		public bool? NotClearDownVelocity;
	}
}
