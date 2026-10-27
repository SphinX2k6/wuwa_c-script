using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A24 RID: 23076
	public static class ISystemModuleDataSyncMotorRacingVerify
	{
		// Token: 0x06027318 RID: 160536 RVA: 0x005641DC File Offset: 0x005623DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemModuleDataSyncMotorRacingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemModuleDataSyncMotorRacingVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorParkourSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C50 RID: 31824
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401374A RID: 79690
			public static VerifyTableAction <0>__Verify;
		}
	}
}
