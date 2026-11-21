using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747C RID: 29820
	public static class IPlayerLookTowardsVerify
	{
		// Token: 0x06034347 RID: 213831 RVA: 0x007083E4 File Offset: 0x007065E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayerLookTowardsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerLookTowardsVerify.<>O.<0>__Verify = new VerifyUnionAction(TCharacterLookAtDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200867E RID: 34430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A6A RID: 84586
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
