using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB1 RID: 19633
	public static class ICustomShapeAreaConflictSelectorVerify
	{
		// Token: 0x0601E1F8 RID: 123384 RVA: 0x0043863C File Offset: 0x0043683C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICustomShapeAreaConflictSelectorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomShapeAreaConflictSelectorVerify.<>O.<0>__Verify = new VerifyUnionAction(TAreaConflictCheckTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICustomShapeAreaConflictSelectorVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICustomShapeAreaConflictSelectorVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008255 RID: 33365
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014424 RID: 82980
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014425 RID: 82981
			public static VerifyTableAction <1>__Verify;
		}
	}
}
