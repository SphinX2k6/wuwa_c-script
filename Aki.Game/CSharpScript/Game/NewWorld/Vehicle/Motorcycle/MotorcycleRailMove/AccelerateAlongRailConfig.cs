using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BE RID: 25022
	[NullableContext(1)]
	[Nullable(0)]
	public class AccelerateAlongRailConfig
	{
		// Token: 0x0603C135 RID: 246069 RVA: 0x01118704 File Offset: 0x01116904
		public void UpdateFromUeData(SMotorRailMoveConfig_AccelerateAlongRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.LinearMoveConfig.UpdateFromUeData(data.LinearMove);
		}

		// Token: 0x0603C136 RID: 246070 RVA: 0x01118728 File Offset: 0x01116928
		public void DeepCopy(AccelerateAlongRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.LinearMoveConfig.DeepCopy(other.LinearMoveConfig);
		}

		// Token: 0x0401FC57 RID: 130135
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC58 RID: 130136
		public readonly LinearMoveConfig LinearMoveConfig = new LinearMoveConfig();
	}
}
