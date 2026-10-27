using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8D RID: 7309
	[NullableContext(2)]
	[Nullable(0)]
	public class IOpenAirWall_SetValue
	{
		// Token: 0x04005F04 RID: 24324
		public EToggleAirWall Type;

		// Token: 0x04005F05 RID: 24325
		public string HitEffectData;

		// Token: 0x04005F06 RID: 24326
		public float? HitCd;

		// Token: 0x04005F07 RID: 24327
		public string AirWallEffectData;

		// Token: 0x04005F08 RID: 24328
		public string VectorArrayAirWallEffectData;

		// Token: 0x04005F09 RID: 24329
		public float? AirWallEffectHeight;

		// Token: 0x04005F0A RID: 24330
		public float? AirWallEffectThickness;

		// Token: 0x04005F0B RID: 24331
		public EAirWallCollisionPreset CollisionPreset;
	}
}
