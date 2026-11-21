using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FFD RID: 20477
	public static class ICheckRogueStateVerify
	{
		// Token: 0x0601FF50 RID: 130896 RVA: 0x0046F9EC File Offset: 0x0046DBEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckRogueStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckRogueStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TRogueStateTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200829A RID: 33434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401447D RID: 83069
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
