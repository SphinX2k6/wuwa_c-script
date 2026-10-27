using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B62 RID: 27490
	public static class IMoveToPointVerify
	{
		// Token: 0x06030424 RID: 197668 RVA: 0x0068EA04 File Offset: 0x0068CC04
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

		// Token: 0x02007DBD RID: 32189
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401395B RID: 80219
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401395C RID: 80220
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
