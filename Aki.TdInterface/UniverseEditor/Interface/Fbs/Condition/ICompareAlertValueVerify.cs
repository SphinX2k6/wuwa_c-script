using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200506C RID: 20588
	public static class ICompareAlertValueVerify
	{
		// Token: 0x0602031D RID: 131869 RVA: 0x00476A90 File Offset: 0x00474C90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICompareAlertValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareAlertValueVerify.<>O.<0>__Verify = new VerifyUnionAction(TComparedAlertValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082A3 RID: 33443
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014489 RID: 83081
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
