using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D01 RID: 27905
	public static class IPlayerLookTowardsVerify
	{
		// Token: 0x06031353 RID: 201555 RVA: 0x006ACEB4 File Offset: 0x006AB0B4
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

		// Token: 0x02007DF3 RID: 32243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A7 RID: 80295
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
