using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200346B RID: 13419
	[NullableContext(1)]
	[Nullable(0)]
	public class CatapultToTargetResult
	{
		// Token: 0x04012DB5 RID: 77237
		public float Time1;

		// Token: 0x04012DB6 RID: 77238
		public readonly Vector StartPoint = Vector.Create();

		// Token: 0x04012DB7 RID: 77239
		public readonly Vector MiddlePoint = Vector.Create();

		// Token: 0x04012DB8 RID: 77240
		public readonly Vector EndPoint = Vector.Create();

		// Token: 0x04012DB9 RID: 77241
		public float GravityMagnitude;

		// Token: 0x04012DBA RID: 77242
		public readonly Rotator EndRotator = Rotator.Create();

		// Token: 0x04012DBB RID: 77243
		public readonly Vector GravityDirect = Vector.Create();
	}
}
