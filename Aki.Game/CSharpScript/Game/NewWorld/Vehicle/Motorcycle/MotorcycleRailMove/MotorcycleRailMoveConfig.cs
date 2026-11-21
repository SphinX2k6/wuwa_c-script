using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061C3 RID: 25027
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleRailMoveConfig : IClear
	{
		// Token: 0x0603C144 RID: 246084 RVA: 0x01118A14 File Offset: 0x01116C14
		public void UpdateFromUeData(SMotorRailMoveConfig data)
		{
			if (data.EnableBasicConfig)
			{
				this.BasicRailMoveConfig.UpdateFromUeData(data.BasicConfig);
			}
			if (data.EnableDirectlyEnterRailConfig)
			{
				this.DirectlyEnterRailConfig.UpdateFromUeData(data.DirectlyEnterRailConfig);
			}
			if (data.EnableAccelerateAlongRailConfig)
			{
				this.AccelerateAlongRailConfig.UpdateFromUeData(data.AccelerateAlongRailConfig);
			}
			if (data.EnableJumpToRailConfig)
			{
				this.JumpToRailConfig.UpdateFromUeData(data.JumpToRailConfig);
			}
			if (data.EnableSwitchRailConfig)
			{
				this.SwitchRailConfig.UpdateFromUeData(data.SwitchRailConfig);
			}
			if (data.EnableJumpOffRailConfig)
			{
				this.JumpOffRailConfig.UpdateFromUeData(data.JumpOffRailConfig);
			}
			if (data.EnableJumpAlongRailConfig)
			{
				this.JumpAlongRailConfig.UpdateFromUeData(data.JumpAlongRailConfig);
			}
		}

		// Token: 0x0603C145 RID: 246085 RVA: 0x01118AD0 File Offset: 0x01116CD0
		public void DeepCopy(MotorcycleRailMoveConfig other)
		{
			this.BasicRailMoveConfig.DeepCopy(other.BasicRailMoveConfig);
			this.DirectlyEnterRailConfig.DeepCopy(other.DirectlyEnterRailConfig);
			this.AccelerateAlongRailConfig.DeepCopy(other.AccelerateAlongRailConfig);
			this.JumpToRailConfig.DeepCopy(other.JumpToRailConfig);
			this.SwitchRailConfig.DeepCopy(other.SwitchRailConfig);
			this.JumpOffRailConfig.DeepCopy(other.JumpOffRailConfig);
			this.JumpAlongRailConfig.DeepCopy(other.JumpAlongRailConfig);
		}

		// Token: 0x0603C146 RID: 246086 RVA: 0x01118B54 File Offset: 0x01116D54
		public bool ClearObject()
		{
			return true;
		}

		// Token: 0x0401FC65 RID: 130149
		public readonly BasicRailMoveConfig BasicRailMoveConfig = new BasicRailMoveConfig();

		// Token: 0x0401FC66 RID: 130150
		public readonly DirectlyEnterRailConfig DirectlyEnterRailConfig = new DirectlyEnterRailConfig();

		// Token: 0x0401FC67 RID: 130151
		public readonly AccelerateAlongRailConfig AccelerateAlongRailConfig = new AccelerateAlongRailConfig();

		// Token: 0x0401FC68 RID: 130152
		public readonly JumpToRailConfig JumpToRailConfig = new JumpToRailConfig();

		// Token: 0x0401FC69 RID: 130153
		public readonly SwitchRailConfig SwitchRailConfig = new SwitchRailConfig();

		// Token: 0x0401FC6A RID: 130154
		public readonly JumpOffRailConfig JumpOffRailConfig = new JumpOffRailConfig();

		// Token: 0x0401FC6B RID: 130155
		public readonly JumpAlongRailConfig JumpAlongRailConfig = new JumpAlongRailConfig();
	}
}
