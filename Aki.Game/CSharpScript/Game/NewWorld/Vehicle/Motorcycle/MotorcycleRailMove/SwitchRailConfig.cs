using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007039 RID: 28729
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitchRailConfig
	{
		// Token: 0x06045F43 RID: 286531 RVA: 0x0116E6C4 File Offset: 0x0116C8C4
		public void UpdateFromUeData(SMotorRailMoveConfig_SwitchRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x06045F44 RID: 286532 RVA: 0x0116E710 File Offset: 0x0116C910
		public void DeepCopy(SwitchRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x04024992 RID: 149906
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x04024993 RID: 149907
		public int SkillId = 100010015;

		// Token: 0x04024994 RID: 149908
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x04024995 RID: 149909
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
