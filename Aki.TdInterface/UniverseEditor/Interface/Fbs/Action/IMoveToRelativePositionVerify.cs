using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B68 RID: 27496
	public static class IMoveToRelativePositionVerify
	{
		// Token: 0x06030458 RID: 197720 RVA: 0x0068F144 File Offset: 0x0068D344
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveToRelativePositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToRelativePositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IMoveToRelativePositionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMoveToRelativePositionVerify.<>O.<1>__Verify = new VerifyUnionAction(TMoveToPointTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DBF RID: 32191
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401395E RID: 80222
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401395F RID: 80223
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
