using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007147 RID: 28999
	public static class ISlideRailEndVerify
	{
		// Token: 0x06033691 RID: 210577 RVA: 0x006ED8A0 File Offset: 0x006EBAA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISlideRailEndVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlideRailEndVerify.<>O.<0>__Verify = new VerifyUnionAction(TSlideRailEndVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E65 RID: 32357
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A42 RID: 80450
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
