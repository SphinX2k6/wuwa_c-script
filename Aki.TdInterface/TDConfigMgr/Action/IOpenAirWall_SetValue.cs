using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E92 RID: 7826
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall_SetValue
	{
		// Token: 0x04006457 RID: 25687
		public EToggleAirWall Type;

		// Token: 0x04006458 RID: 25688
		public string HitEffectData;

		// Token: 0x04006459 RID: 25689
		public float? HitCd;

		// Token: 0x0400645A RID: 25690
		public string AirWallEffectData;

		// Token: 0x0400645B RID: 25691
		public string VectorArrayAirWallEffectData;

		// Token: 0x0400645C RID: 25692
		public int? AirWallEffectSplineEntityId;

		// Token: 0x0400645D RID: 25693
		public float? AirWallEffectHeight;

		// Token: 0x0400645E RID: 25694
		public float? AirWallEffectThickness;

		// Token: 0x0400645F RID: 25695
		public EAirWallCollisionPreset CollisionPreset;
	}
}
