using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AE RID: 29358
	public static class IMoveToRelativePositionVerify
	{
		// Token: 0x060332AF RID: 209583 RVA: 0x006E7700 File Offset: 0x006E5900
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

		// Token: 0x02008647 RID: 34375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A1D RID: 84509
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A1E RID: 84510
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
