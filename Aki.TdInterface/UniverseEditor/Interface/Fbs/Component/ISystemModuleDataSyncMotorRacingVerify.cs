using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006031 RID: 24625
	public static class ISystemModuleDataSyncMotorRacingVerify
	{
		// Token: 0x06029890 RID: 170128 RVA: 0x005AB1A0 File Offset: 0x005A93A0
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

		// Token: 0x020084BF RID: 33983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147EE RID: 83950
			public static VerifyTableAction <0>__Verify;
		}
	}
}
