using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x020061D3 RID: 25043
	public class BounceParam
	{
		// Token: 0x0401FCCD RID: 130253
		public int? SkillId;

		// Token: 0x0401FCCE RID: 130254
		[Nullable(2)]
		public string CurvePath;

		// Token: 0x0401FCCF RID: 130255
		public float? Time;

		// Token: 0x0401FCD0 RID: 130256
		public float? Height;

		// Token: 0x0401FCD1 RID: 130257
		public bool? UseLocalUp;

		// Token: 0x0401FCD2 RID: 130258
		public bool? NotClearDownVelocity;
	}
}
