using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007324 RID: 29476
	public static class INpcLeisureInteractVerify
	{
		// Token: 0x0603366A RID: 210538 RVA: 0x006EE1F8 File Offset: 0x006EC3F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcLeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcLeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcLeisureInteractOpVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008651 RID: 34385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2D RID: 84525
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
