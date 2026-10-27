using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703E RID: 28734
	public class ParabolaMoveConfig
	{
		// Token: 0x06045F52 RID: 286546 RVA: 0x0116E9FA File Offset: 0x0116CBFA
		public void UpdateFromUeData(SMotorRailMove_ParabolaMove data)
		{
			this.GravityAccelerationAbs = data.GravityAccelerationAbs;
			this.Duration = data.Duration;
			this.MinSpeedAlongRail = data.MinSpeedAlongRail;
			this.MaxSpeedAlongRail = data.MaxSpeedAlongRail;
		}

		// Token: 0x06045F53 RID: 286547 RVA: 0x0116EA2C File Offset: 0x0116CC2C
		[NullableContext(1)]
		public void DeepCopy(ParabolaMoveConfig other)
		{
			this.GravityAccelerationAbs = other.GravityAccelerationAbs;
			this.Duration = other.Duration;
			this.MinSpeedAlongRail = other.MinSpeedAlongRail;
			this.MaxSpeedAlongRail = other.MaxSpeedAlongRail;
		}

		// Token: 0x040249A3 RID: 149923
		public float GravityAccelerationAbs = 980f;

		// Token: 0x040249A4 RID: 149924
		public float Duration = 0.5f;

		// Token: 0x040249A5 RID: 149925
		public float MinSpeedAlongRail = 10f;

		// Token: 0x040249A6 RID: 149926
		public float MaxSpeedAlongRail = 3500f;
	}
}
