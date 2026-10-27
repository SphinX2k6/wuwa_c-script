using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007038 RID: 28728
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpToRailConfig
	{
		// Token: 0x06045F40 RID: 286528 RVA: 0x0116E5F8 File Offset: 0x0116C7F8
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpToRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x06045F41 RID: 286529 RVA: 0x0116E644 File Offset: 0x0116C844
		public void DeepCopy(JumpToRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0402498E RID: 149902
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0402498F RID: 149903
		public int SkillId = 100010012;

		// Token: 0x04024990 RID: 149904
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x04024991 RID: 149905
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
