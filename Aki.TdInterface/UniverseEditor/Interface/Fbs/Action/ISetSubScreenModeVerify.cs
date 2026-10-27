using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007084 RID: 28804
	public static class ISetSubScreenModeVerify
	{
		// Token: 0x06033005 RID: 208901 RVA: 0x006E1264 File Offset: 0x006DF464
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetSubScreenModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetSubScreenModeVerify.<>O.<0>__Verify = new VerifyUnionAction(TSubScreenModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E52 RID: 32338
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A29 RID: 80425
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
