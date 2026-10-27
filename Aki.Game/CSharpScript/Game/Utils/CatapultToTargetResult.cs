using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004543 RID: 17731
	[NullableContext(1)]
	[Nullable(0)]
	public class CatapultToTargetResult
	{
		// Token: 0x0401877B RID: 100219
		public float Time1;

		// Token: 0x0401877C RID: 100220
		public readonly Vector StartPoint = Vector.Create();

		// Token: 0x0401877D RID: 100221
		public readonly Vector MiddlePoint = Vector.Create();

		// Token: 0x0401877E RID: 100222
		public readonly Vector EndPoint = Vector.Create();

		// Token: 0x0401877F RID: 100223
		public float GravityMagnitude;

		// Token: 0x04018780 RID: 100224
		public readonly Rotator EndRotator = Rotator.Create();

		// Token: 0x04018781 RID: 100225
		public readonly Vector GravityDirect = Vector.Create();
	}
}
