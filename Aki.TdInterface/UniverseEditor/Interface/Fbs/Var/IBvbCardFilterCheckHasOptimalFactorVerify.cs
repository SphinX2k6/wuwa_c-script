using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A32 RID: 14898
	public static class IBvbCardFilterCheckHasOptimalFactorVerify
	{
		// Token: 0x06014287 RID: 82567 RVA: 0x002F2A24 File Offset: 0x002F0C24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbCardFilterCheckHasOptimalFactorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbCardFilterCheckHasOptimalFactorVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007873 RID: 30835
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DB RID: 78043
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
