using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BA RID: 25018
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitchRailConfig
	{
		// Token: 0x0603C129 RID: 246057 RVA: 0x01118434 File Offset: 0x01116634
		public void UpdateFromUeData(SMotorRailMoveConfig_SwitchRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x0603C12A RID: 246058 RVA: 0x01118480 File Offset: 0x01116680
		public void DeepCopy(SwitchRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0401FC48 RID: 130120
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC49 RID: 130121
		public int SkillId = 100010015;

		// Token: 0x0401FC4A RID: 130122
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x0401FC4B RID: 130123
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
