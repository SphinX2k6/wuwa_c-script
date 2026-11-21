using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E3 RID: 21731
	public static class ICircuitConnectLevelDataVerify
	{
		// Token: 0x060224FC RID: 140540 RVA: 0x004BADE4 File Offset: 0x004B8FE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICircuitConnectLevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircuitConnectLevelDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TCircuitConnectModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICircuitConnectLevelDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICircuitConnectLevelDataVerify.<>O.<1>__Verify = new VerifyTableAction(ICircuitConnectLinkageGroupVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICircuitConnectLevelDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICircuitConnectLevelDataVerify.<>O.<2>__Verify = new VerifyTableAction(ICircuitConnectLayoutVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008308 RID: 33544
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014516 RID: 83222
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014517 RID: 83223
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014518 RID: 83224
			public static VerifyTableAction <2>__Verify;
		}
	}
}
