using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DA RID: 21722
	public static class ICircuitConnectLayoutVerify
	{
		// Token: 0x060224A6 RID: 140454 RVA: 0x004BA21C File Offset: 0x004B841C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICircuitConnectLayoutVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircuitConnectLayoutVerify.<>O.<0>__Verify = new VerifyUnionAction(TCircuitConnectLayoutTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICircuitConnectLayoutVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICircuitConnectLayoutVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICircuitConnectLayoutVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ICircuitConnectLayoutVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008307 RID: 33543
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014514 RID: 83220
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014515 RID: 83221
			public static VerifyTableAction <1>__Verify;
		}
	}
}
