using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007042 RID: 28738
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleRailMoveConfig : IClear
	{
		// Token: 0x06045F5E RID: 286558 RVA: 0x0116EC9C File Offset: 0x0116CE9C
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

		// Token: 0x06045F5F RID: 286559 RVA: 0x0116ED58 File Offset: 0x0116CF58
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

		// Token: 0x06045F60 RID: 286560 RVA: 0x0116EDDC File Offset: 0x0116CFDC
		public bool ClearObject()
		{
			return true;
		}

		// Token: 0x040249AF RID: 149935
		public readonly BasicRailMoveConfig BasicRailMoveConfig = new BasicRailMoveConfig();

		// Token: 0x040249B0 RID: 149936
		public readonly DirectlyEnterRailConfig DirectlyEnterRailConfig = new DirectlyEnterRailConfig();

		// Token: 0x040249B1 RID: 149937
		public readonly AccelerateAlongRailConfig AccelerateAlongRailConfig = new AccelerateAlongRailConfig();

		// Token: 0x040249B2 RID: 149938
		public readonly JumpToRailConfig JumpToRailConfig = new JumpToRailConfig();

		// Token: 0x040249B3 RID: 149939
		public readonly SwitchRailConfig SwitchRailConfig = new SwitchRailConfig();

		// Token: 0x040249B4 RID: 149940
		public readonly JumpOffRailConfig JumpOffRailConfig = new JumpOffRailConfig();

		// Token: 0x040249B5 RID: 149941
		public readonly JumpAlongRailConfig JumpAlongRailConfig = new JumpAlongRailConfig();
	}
}
