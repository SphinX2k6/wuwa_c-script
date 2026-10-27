using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200633C RID: 25404
	public static class ICharacterLookAtVerify
	{
		// Token: 0x0602BF1F RID: 179999 RVA: 0x0060A500 File Offset: 0x00608700
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

		// Token: 0x02007D12 RID: 32018
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013876 RID: 79990
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
