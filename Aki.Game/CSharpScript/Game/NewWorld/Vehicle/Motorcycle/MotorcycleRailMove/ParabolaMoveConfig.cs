using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BF RID: 25023
	public class ParabolaMoveConfig
	{
		// Token: 0x0603C138 RID: 246072 RVA: 0x0111876A File Offset: 0x0111696A
		public void UpdateFromUeData(SMotorRailMove_ParabolaMove data)
		{
			this.GravityAccelerationAbs = data.GravityAccelerationAbs;
			this.Duration = data.Duration;
			this.MinSpeedAlongRail = data.MinSpeedAlongRail;
			this.MaxSpeedAlongRail = data.MaxSpeedAlongRail;
		}

		// Token: 0x0603C139 RID: 246073 RVA: 0x0111879C File Offset: 0x0111699C
		[NullableContext(1)]
		public void DeepCopy(ParabolaMoveConfig other)
		{
			this.GravityAccelerationAbs = other.GravityAccelerationAbs;
			this.Duration = other.Duration;
			this.MinSpeedAlongRail = other.MinSpeedAlongRail;
			this.MaxSpeedAlongRail = other.MaxSpeedAlongRail;
		}

		// Token: 0x0401FC59 RID: 130137
		public float GravityAccelerationAbs = 980f;

		// Token: 0x0401FC5A RID: 130138
		public float Duration = 0.5f;

		// Token: 0x0401FC5B RID: 130139
		public float MinSpeedAlongRail = 10f;

		// Token: 0x0401FC5C RID: 130140
		public float MaxSpeedAlongRail = 3500f;
	}
}
