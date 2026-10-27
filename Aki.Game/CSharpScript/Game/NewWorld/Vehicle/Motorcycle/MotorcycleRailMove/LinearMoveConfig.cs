using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703F RID: 28735
	public class LinearMoveConfig
	{
		// Token: 0x06045F55 RID: 286549 RVA: 0x0116EA92 File Offset: 0x0116CC92
		public void UpdateFromUeData(SMotorRailMove_LinearMove data)
		{
			this.MinSpeed = data.MinSpeed;
			this.MaxSpeed = data.MaxSpeed;
		}

		// Token: 0x06045F56 RID: 286550 RVA: 0x0116EAAC File Offset: 0x0116CCAC
		[NullableContext(1)]
		public void DeepCopy(LinearMoveConfig other)
		{
			this.MinSpeed = other.MinSpeed;
			this.MaxSpeed = other.MaxSpeed;
		}

		// Token: 0x040249A7 RID: 149927
		public float MinSpeed = 10f;

		// Token: 0x040249A8 RID: 149928
		public float MaxSpeed = 3500f;
	}
}
