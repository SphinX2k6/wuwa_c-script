using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3A RID: 15930
	public static class IBvbGetCardEvolvedUseVerify
	{
		// Token: 0x0601572B RID: 87851 RVA: 0x003189B8 File Offset: 0x00316BB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardEvolvedUseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardEvolvedUseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B5 RID: 32949
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014134 RID: 82228
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
