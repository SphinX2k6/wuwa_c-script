using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004456 RID: 17494
	public static class IQuestScheduleBtTreeVarVerify
	{
		// Token: 0x0601918F RID: 102799 RVA: 0x003946A0 File Offset: 0x003928A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestScheduleBtTreeVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleBtTreeVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestScheduleBtTreeVarVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestScheduleBtTreeVarVerify.<>O.<1>__Verify = new VerifyTableAction(IWordArtConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200817A RID: 33146
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142A5 RID: 82597
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040142A6 RID: 82598
			public static VerifyTableAction <1>__Verify;
		}
	}
}
