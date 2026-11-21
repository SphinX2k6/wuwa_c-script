using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425B RID: 16987
	public static class IFastReturnGravityEntityPosVerify
	{
		// Token: 0x06017AA3 RID: 96931 RVA: 0x003603EC File Offset: 0x0035E5EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFastReturnGravityEntityPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFastReturnGravityEntityPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200811F RID: 33055
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141DC RID: 82396
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
