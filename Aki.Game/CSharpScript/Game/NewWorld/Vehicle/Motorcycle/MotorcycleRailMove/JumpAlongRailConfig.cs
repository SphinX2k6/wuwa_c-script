using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BC RID: 25020
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpAlongRailConfig
	{
		// Token: 0x0603C12F RID: 246063 RVA: 0x011185AC File Offset: 0x011167AC
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpAlongRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x0603C130 RID: 246064 RVA: 0x011185DC File Offset: 0x011167DC
		public void DeepCopy(JumpAlongRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0401FC50 RID: 130128
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC51 RID: 130129
		public int SkillId = 100010016;

		// Token: 0x0401FC52 RID: 130130
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
