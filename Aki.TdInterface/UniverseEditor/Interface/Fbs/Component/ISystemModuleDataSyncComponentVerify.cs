using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1B RID: 23067
	public static class ISystemModuleDataSyncComponentVerify
	{
		// Token: 0x060272DA RID: 160474 RVA: 0x00563B30 File Offset: 0x00561D30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISystemModuleDataSyncComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemModuleDataSyncComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemModuleDataSyncMotorRacingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C4F RID: 31823
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013749 RID: 79689
			public static VerifyTableAction <0>__Verify;
		}
	}
}
