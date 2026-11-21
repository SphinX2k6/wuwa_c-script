using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A8 RID: 29352
	public static class IMoveToPointVerify
	{
		// Token: 0x0603327B RID: 209531 RVA: 0x006E6FC0 File Offset: 0x006E51C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IMoveToPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMoveToPointVerify.<>O.<1>__Verify = new VerifyUnionAction(TMoveToPointTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008645 RID: 34373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A1A RID: 84506
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A1B RID: 84507
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
