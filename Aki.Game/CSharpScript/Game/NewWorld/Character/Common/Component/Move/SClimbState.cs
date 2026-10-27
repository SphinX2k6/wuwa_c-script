using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070DA RID: 28890
	[NullableContext(1)]
	[Nullable(0)]
	public class SClimbState
	{
		// Token: 0x060467DF RID: 288735 RVA: 0x011B3FC5 File Offset: 0x011B21C5
		public SClimbState(EClimbState? 攀爬状态 = null, EEnterClimb? 进入攀爬类型 = null, EExitClimb? 退出攀爬类型 = null)
		{
			this.攀爬状态 = 攀爬状态.GetValueOrDefault();
			this.进入攀爬类型 = 进入攀爬类型.GetValueOrDefault();
			this.退出攀爬类型 = 退出攀爬类型.GetValueOrDefault();
		}

		// Token: 0x060467E0 RID: 288736 RVA: 0x011B3FF4 File Offset: 0x011B21F4
		[NullableContext(2)]
		public bool Equals(SClimbState inB)
		{
			return inB != null && this.攀爬状态 == inB.攀爬状态 && this.进入攀爬类型 == inB.进入攀爬类型 && this.退出攀爬类型 == inB.退出攀爬类型;
		}

		// Token: 0x060467E1 RID: 288737 RVA: 0x011B4025 File Offset: 0x011B2225
		public void DeepCopy(SClimbState other)
		{
			this.攀爬状态 = other.攀爬状态;
			this.进入攀爬类型 = other.进入攀爬类型;
			this.退出攀爬类型 = other.退出攀爬类型;
		}

		// Token: 0x060467E2 RID: 288738 RVA: 0x011B404B File Offset: 0x011B224B
		public SClimbState Copy()
		{
			return new SClimbState(new EClimbState?(this.攀爬状态), new EEnterClimb?(this.进入攀爬类型), new EExitClimb?(this.退出攀爬类型));
		}

		// Token: 0x04024F2C RID: 151340
		public EClimbState 攀爬状态;

		// Token: 0x04024F2D RID: 151341
		public EEnterClimb 进入攀爬类型;

		// Token: 0x04024F2E RID: 151342
		public EExitClimb 退出攀爬类型;
	}
}
