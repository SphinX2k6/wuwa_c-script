using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047EF RID: 18415
	public static class IRunningResetReviveInfoVerify
	{
		// Token: 0x0601C7B9 RID: 116665 RVA: 0x00407844 File Offset: 0x00405A44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningResetReviveInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningResetReviveInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRunningResetReviveInfoVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRunningResetReviveInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IInstEntityDataVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A05 RID: 31237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B4 RID: 78772
			public static VerifyTableAction <0>__Verify;
		}
	}
}
