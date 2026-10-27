using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007040 RID: 28736
	public class EnterRailCondition
	{
		// Token: 0x06045F58 RID: 286552 RVA: 0x0116EAE4 File Offset: 0x0116CCE4
		public void UpdateFromUeData(SMotorRailMove_EnterRailCondition data)
		{
			this.MaxAngleBetweenForwardAndRailTangent = data.MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = data.MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = data.MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = data.MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = data.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x06045F59 RID: 286553 RVA: 0x0116EB22 File Offset: 0x0116CD22
		[NullableContext(1)]
		public void DeepCopy(EnterRailCondition other)
		{
			this.MaxAngleBetweenForwardAndRailTangent = other.MaxAngleBetweenForwardAndRailTangent;
			this.MaxAngleBetweenUpAndRailUp = other.MaxAngleBetweenUpAndRailUp;
			this.MaxAngleBetweenVelocityAndRailTangent = other.MaxAngleBetweenVelocityAndRailTangent;
			this.MinRailLenLeftAfterEnterRail = other.MinRailLenLeftAfterEnterRail;
			this.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = other.MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent;
		}

		// Token: 0x040249A9 RID: 149929
		public float MaxAngleBetweenForwardAndRailTangent = 90f;

		// Token: 0x040249AA RID: 149930
		public float MaxAngleBetweenUpAndRailUp = 90f;

		// Token: 0x040249AB RID: 149931
		public float MaxAngleBetweenVelocityAndRailTangent = 90f;

		// Token: 0x040249AC RID: 149932
		public float MinRailLenLeftAfterEnterRail = 100f;

		// Token: 0x040249AD RID: 149933
		public float MaxAngleBetweenTargetUpAndDirPlaneProjectionOfTargetToCurrent = 90f;
	}
}
