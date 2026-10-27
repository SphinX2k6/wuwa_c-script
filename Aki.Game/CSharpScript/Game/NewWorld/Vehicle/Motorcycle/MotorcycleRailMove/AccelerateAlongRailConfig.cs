using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703D RID: 28733
	[NullableContext(1)]
	[Nullable(0)]
	public class AccelerateAlongRailConfig
	{
		// Token: 0x06045F4F RID: 286543 RVA: 0x0116E994 File Offset: 0x0116CB94
		public void UpdateFromUeData(SMotorRailMoveConfig_AccelerateAlongRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.LinearMoveConfig.UpdateFromUeData(data.LinearMove);
		}

		// Token: 0x06045F50 RID: 286544 RVA: 0x0116E9B8 File Offset: 0x0116CBB8
		public void DeepCopy(AccelerateAlongRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.LinearMoveConfig.DeepCopy(other.LinearMoveConfig);
		}

		// Token: 0x040249A1 RID: 149921
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x040249A2 RID: 149922
		public readonly LinearMoveConfig LinearMoveConfig = new LinearMoveConfig();
	}
}
