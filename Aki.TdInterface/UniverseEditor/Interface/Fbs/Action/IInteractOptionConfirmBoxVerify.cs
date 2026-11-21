using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704B RID: 28747
	public static class IInteractOptionConfirmBoxVerify
	{
		// Token: 0x06031D7E RID: 204158 RVA: 0x006BF5A4 File Offset: 0x006BD7A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInteractOptionConfirmBoxVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractOptionConfirmBoxVerify.<>O.<0>__Verify = new VerifyUnionAction(TInteractOptionConfirmBoxOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200860B RID: 34315
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D1 RID: 84433
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
