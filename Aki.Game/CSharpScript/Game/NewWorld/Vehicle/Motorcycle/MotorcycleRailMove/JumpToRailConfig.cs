using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061B9 RID: 25017
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpToRailConfig
	{
		// Token: 0x0603C126 RID: 246054 RVA: 0x01118368 File Offset: 0x01116568
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpToRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.EnterRailCondition.UpdateFromUeData(data.EnterCondition);
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x0603C127 RID: 246055 RVA: 0x011183B4 File Offset: 0x011165B4
		public void DeepCopy(JumpToRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.EnterRailCondition.DeepCopy(other.EnterRailCondition);
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0401FC44 RID: 130116
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC45 RID: 130117
		public int SkillId = 100010012;

		// Token: 0x0401FC46 RID: 130118
		public readonly EnterRailCondition EnterRailCondition = new EnterRailCondition();

		// Token: 0x0401FC47 RID: 130119
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
