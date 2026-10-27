using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050A4 RID: 20644
	public static class IDollGrabMachineComponentVerify
	{
		// Token: 0x06021286 RID: 135814 RVA: 0x0049B664 File Offset: 0x00499864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollGrabMachineComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollGrabMachineComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDollGrabItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDollGrabMachineComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDollGrabMachineComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IDollGrabInfiniteModeDataVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007AD9 RID: 31449
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134E3 RID: 79075
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134E4 RID: 79076
			public static VerifyTableAction <1>__Verify;
		}
	}
}
