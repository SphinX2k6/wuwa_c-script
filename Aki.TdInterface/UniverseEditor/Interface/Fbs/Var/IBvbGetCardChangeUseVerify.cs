using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5C RID: 14940
	public static class IBvbGetCardChangeUseVerify
	{
		// Token: 0x060143F2 RID: 82930 RVA: 0x002F5340 File Offset: 0x002F3540
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardChangeUseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardChangeUseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007876 RID: 30838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DE RID: 78046
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
