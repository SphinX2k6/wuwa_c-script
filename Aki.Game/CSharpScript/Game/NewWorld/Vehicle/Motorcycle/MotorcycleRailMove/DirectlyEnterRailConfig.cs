using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BD RID: 25021
	[NullableContext(1)]
	[Nullable(0)]
	public class DirectlyEnterRailConfig
	{
		// Token: 0x0603C132 RID: 246066 RVA: 0x01118638 File Offset: 0x01116838
		public void UpdateFromUeData(SMotorRailMoveConfig_DirectlyEnterRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.MaxAbsorbDist = data.MaxAbsorbDist;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.LinearMoveConfig.UpdateFromUeData(data.LinearMove);
		}

		// Token: 0x0603C133 RID: 246067 RVA: 0x01118684 File Offset: 0x01116884
		public void DeepCopy(DirectlyEnterRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.MaxAbsorbDist = other.MaxAbsorbDist;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.LinearMoveConfig.DeepCopy(other.LinearMoveConfig);
		}

		// Token: 0x0401FC53 RID: 130131
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC54 RID: 130132
		public float MaxAbsorbDist = 100f;

		// Token: 0x0401FC55 RID: 130133
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x0401FC56 RID: 130134
		public readonly LinearMoveConfig LinearMoveConfig = new LinearMoveConfig();
	}
}
