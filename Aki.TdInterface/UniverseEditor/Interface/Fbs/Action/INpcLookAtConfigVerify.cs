using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732D RID: 29485
	public static class INpcLookAtConfigVerify
	{
		// Token: 0x060336BD RID: 210621 RVA: 0x006EEBCC File Offset: 0x006ECDCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcLookAtConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcLookAtConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcLookAtTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008652 RID: 34386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2E RID: 84526
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
