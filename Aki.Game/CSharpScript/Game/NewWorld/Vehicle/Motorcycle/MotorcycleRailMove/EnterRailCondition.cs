using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C1 RID: 25025
	public class EnterRailCondition
	{
		// Token: 0x0603C13E RID: 246078 RVA: 0x01118854 File Offset: 0x01116A54
		public void UpdateFromUeData(SMotorRailMove_EnterRailCondition data)
		{
			this.MaxAngleBetweenForwardAndRailTangent = data.MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = data.MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = data.MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = data.MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = data.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0603C13F RID: 246079 RVA: 0x01118892 File Offset: 0x01116A92
		[NullableContext(1)]
		public void DeepCopy(EnterRailCondition other)
		{
			this.MaxAngleBetweenForwardAndRailTangent = other.MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = other.MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = other.MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = other.MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = other.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x0401FC5F RID: 130143
		public float MaxAngleBetweenForwardAndRailTangent = 90f;

		// Token: 0x0401FC60 RID: 130144
		public float MaxAngleBetweenUpAndRailUp = 90f;

		// Token: 0x0401FC61 RID: 130145
		public float MaxAngleBetweenVelocityAndRailTangent = 90f;

		// Token: 0x0401FC62 RID: 130146
		public float MinRailLenLeftAfterEnterRail = 100f;

		// Token: 0x0401FC63 RID: 130147
		public float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = 90f;
	}
}
