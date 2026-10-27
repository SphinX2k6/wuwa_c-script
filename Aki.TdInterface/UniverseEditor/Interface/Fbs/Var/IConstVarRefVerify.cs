using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A92 RID: 14994
	public static class IConstVarRefVerify
	{
		// Token: 0x06014583 RID: 83331 RVA: 0x002F7E54 File Offset: 0x002F6054
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConstVarRefVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConstVarRefVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200787A RID: 30842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E2 RID: 78050
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
