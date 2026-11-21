using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C0 RID: 25024
	public class LinearMoveConfig
	{
		// Token: 0x0603C13B RID: 246075 RVA: 0x01118802 File Offset: 0x01116A02
		public void UpdateFromUeData(SMotorRailMove_LinearMove data)
		{
			this.MinSpeed = data.MinSpeed;
			this.MaxSpeed = data.MaxSpeed;
		}

		// Token: 0x0603C13C RID: 246076 RVA: 0x0111881C File Offset: 0x01116A1C
		[NullableContext(1)]
		public void DeepCopy(LinearMoveConfig other)
		{
			this.MinSpeed = other.MinSpeed;
			this.MaxSpeed = other.MaxSpeed;
		}

		// Token: 0x0401FC5D RID: 130141
		public float MinSpeed = 10f;

		// Token: 0x0401FC5E RID: 130142
		public float MaxSpeed = 3500f;
	}
}
