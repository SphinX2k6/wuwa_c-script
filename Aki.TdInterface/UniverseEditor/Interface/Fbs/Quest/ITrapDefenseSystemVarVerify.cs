using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004699 RID: 18073
	public static class ITrapDefenseSystemVarVerify
	{
		// Token: 0x0601A8A6 RID: 108710 RVA: 0x003C6BE4 File Offset: 0x003C4DE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrapDefenseSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrapDefenseSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081C1 RID: 33217
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014357 RID: 82775
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
