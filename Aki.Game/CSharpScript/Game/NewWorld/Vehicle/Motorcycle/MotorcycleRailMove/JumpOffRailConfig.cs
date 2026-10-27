using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove.Struct;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x0200703A RID: 28730
	[NullableContext(1)]
	[Nullable(0)]
	public class JumpOffRailConfig
	{
		// Token: 0x06045F46 RID: 286534 RVA: 0x0116E790 File Offset: 0x0116C990
		public void UpdateFromUeData(SMotorRailMoveConfig_JumpOffRail data)
		{
			this.CommonConfig.UpdateFromUeData(data.CommonConfig);
			this.SkillId = data.SkillId;
			this.SideOffsetAbs = data.SideOffsetAbs;
			this.ParabolaMoveConfig.UpdateFromUeData(data.ParabolaMove);
		}

		// Token: 0x06045F47 RID: 286535 RVA: 0x0116E7CC File Offset: 0x0116C9CC
		public void DeepCopy(JumpOffRailConfig other)
		{
			this.CommonConfig.DeepCopy(other.CommonConfig);
			this.SkillId = other.SkillId;
			this.SideOffsetAbs = other.SideOffsetAbs;
			this.ParabolaMoveConfig.DeepCopy(other.ParabolaMoveConfig);
		}

		// Token: 0x04024996 RID: 149910
		public readonly CommonConfig CommonConfig = new CommonConfig();

		// Token: 0x04024997 RID: 149911
		public int SkillId = 100010016;

		// Token: 0x04024998 RID: 149912
		public float SideOffsetAbs = 300f;

		// Token: 0x04024999 RID: 149913
		public readonly ParabolaMoveConfig ParabolaMoveConfig = new ParabolaMoveConfig();
	}
}
