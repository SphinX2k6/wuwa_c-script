using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AD RID: 27053
	public static class ICharacterLookAtVerify
	{
		// Token: 0x0602E689 RID: 190089 RVA: 0x00655654 File Offset: 0x00653854
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICharacterLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterLookAtVerify.<>O.<0>__Verify = new VerifyUnionAction(TCharacterLookAtDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008586 RID: 34182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014920 RID: 84256
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
