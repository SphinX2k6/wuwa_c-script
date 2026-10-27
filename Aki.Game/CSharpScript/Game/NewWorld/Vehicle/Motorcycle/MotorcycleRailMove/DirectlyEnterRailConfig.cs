using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703C RID: 28732
	[NullableContext(1)]
	[Nullable(0)]
	public class DirectlyEnterRailConfig
	{
		// Token: 0x06045F4C RID: 286540 RVA: 0x0116E8C8 File Offset: 0x0116CAC8
		public void UpdateFromUeData(SMotorRailMoveConfig_DirectlyEnterRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.MaxAbsorbDist = data.MaxAbsorbDist;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.LinearMoveConfig.UpdateFromUeData(data.LinearMove);
		}

		// Token: 0x06045F4D RID: 286541 RVA: 0x0116E914 File Offset: 0x0116CB14
		public void DeepCopy(DirectlyEnterRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.MaxAbsorbDist = other.MaxAbsorbDist;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.LinearMoveConfig.DeepCopy(other.LinearMoveConfig);
		}

		// Token: 0x0402499D RID: 149917
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0402499E RID: 149918
		public float MaxAbsorbDist = 100f;

		// Token: 0x0402499F RID: 149919
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x040249A0 RID: 149920
		public readonly LinearMoveConfig LinearMoveConfig = new LinearMoveConfig();
	}
}
