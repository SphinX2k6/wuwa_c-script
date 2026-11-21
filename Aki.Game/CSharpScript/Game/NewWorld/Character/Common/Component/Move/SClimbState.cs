using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200638A RID: 25482
	[NullableContext(1)]
	[Nullable(0)]
	public class SClimbState
	{
		// Token: 0x0603DBC7 RID: 252871 RVA: 0x011E39A1 File Offset: 0x011E1BA1
		public SClimbState(EClimbState? 攀爬状态 = null, EEnterClimb? 进入攀爬类型 = null, EExitClimb? 退出攀爬类型 = null)
		{
			this.攀爬状态 = 攀爬状态.GetValueOrDefault();
			this.进入攀爬类型 = 进入攀爬类型.GetValueOrDefault();
			this.退出攀爬类型 = 退出攀爬类型.GetValueOrDefault();
		}

		// Token: 0x0603DBC8 RID: 252872 RVA: 0x011E39D0 File Offset: 0x011E1BD0
		[NullableContext(2)]
		public bool Equals(SClimbState inB)
		{
			return inB != null && this.攀爬状态 == inB.攀爬状态 && this.进入攀爬类型 == inB.进入攀爬类型 && this.退出攀爬类型 == inB.退出攀爬类型;
		}

		// Token: 0x0603DBC9 RID: 252873 RVA: 0x011E3A01 File Offset: 0x011E1C01
		public void DeepCopy(SClimbState other)
		{
			this.攀爬状态 = other.攀爬状态;
			this.进入攀爬类型 = other.进入攀爬类型;
			this.退出攀爬类型 = other.退出攀爬类型;
		}

		// Token: 0x0603DBCA RID: 252874 RVA: 0x011E3A27 File Offset: 0x011E1C27
		public SClimbState Copy()
		{
			return new SClimbState(new EClimbState?(this.攀爬状态), new EEnterClimb?(this.进入攀爬类型), new EExitClimb?(this.退出攀爬类型));
		}

		// Token: 0x04020BBF RID: 134079
		public EClimbState 攀爬状态;

		// Token: 0x04020BC0 RID: 134080
		public EEnterClimb 进入攀爬类型;

		// Token: 0x04020BC1 RID: 134081
		public EExitClimb 退出攀爬类型;
	}
}
