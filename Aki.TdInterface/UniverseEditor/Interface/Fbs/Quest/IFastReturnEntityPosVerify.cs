using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004258 RID: 16984
	public static class IFastReturnEntityPosVerify
	{
		// Token: 0x06017A7C RID: 96892 RVA: 0x0035FCC0 File Offset: 0x0035DEC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFastReturnEntityPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFastReturnEntityPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200811E RID: 33054
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141DB RID: 82395
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
