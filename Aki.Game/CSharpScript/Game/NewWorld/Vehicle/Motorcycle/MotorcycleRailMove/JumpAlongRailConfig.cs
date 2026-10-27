using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703B RID: 28731
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpAlongRailConfig
	{
		// Token: 0x06045F49 RID: 286537 RVA: 0x0116E83C File Offset: 0x0116CA3C
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpAlongRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x06045F4A RID: 286538 RVA: 0x0116E86C File Offset: 0x0116CA6C
		public void DeepCopy(JumpAlongRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0402499A RID: 149914
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0402499B RID: 149915
		public int SkillId = 100010016;

		// Token: 0x0402499C RID: 149916
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
