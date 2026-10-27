using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4F RID: 19279
	public static class ICheckTargetEntityVerify
	{
		// Token: 0x0601E5C2 RID: 124354 RVA: 0x00440F04 File Offset: 0x0043F104
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckTargetEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A4D RID: 31309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013414 RID: 78868
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
