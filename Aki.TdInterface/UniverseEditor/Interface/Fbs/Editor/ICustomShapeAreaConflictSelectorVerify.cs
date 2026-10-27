using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004849 RID: 18505
	public static class ICustomShapeAreaConflictSelectorVerify
	{
		// Token: 0x0601C9FB RID: 117243 RVA: 0x0040BCEC File Offset: 0x00409EEC
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

		// Token: 0x02007A0C RID: 31244
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133BD RID: 78781
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040133BE RID: 78782
			public static VerifyTableAction <1>__Verify;
		}
	}
}
