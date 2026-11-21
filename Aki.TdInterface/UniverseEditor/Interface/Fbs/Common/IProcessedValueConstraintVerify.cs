using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006484 RID: 25732
	public static class IProcessedValueConstraintVerify
	{
		// Token: 0x0602BB9C RID: 179100 RVA: 0x005F2FAC File Offset: 0x005F11AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IProcessedValueConstraintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProcessedValueConstraintVerify.<>O.<0>__Verify = new VerifyUnionAction(TConstraintValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008524 RID: 34084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014887 RID: 84103
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
