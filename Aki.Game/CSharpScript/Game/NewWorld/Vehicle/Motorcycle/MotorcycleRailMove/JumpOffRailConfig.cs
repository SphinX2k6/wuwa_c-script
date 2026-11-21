using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061BB RID: 25019
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpOffRailConfig
	{
		// Token: 0x0603C12C RID: 246060 RVA: 0x01118500 File Offset: 0x01116700
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpOffRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.SideOffsetAbs = data.SideOffsetAbs;
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x0603C12D RID: 246061 RVA: 0x0111853C File Offset: 0x0111673C
		public void DeepCopy(JumpOffRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.SideOffsetAbs = other.SideOffsetAbs;
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x0401FC4C RID: 130124
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x0401FC4D RID: 130125
		public int SkillId = 100010016;

		// Token: 0x0401FC4E RID: 130126
		public float SideOffsetAbs = 300f;

		// Token: 0x0401FC4F RID: 130127
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
