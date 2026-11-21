using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007093 RID: 28819
	public static class ILeisureInteractVerify
	{
		// Token: 0x06032028 RID: 204840 RVA: 0x006C52C8 File Offset: 0x006C34C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TLeisureInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008612 RID: 34322
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149DB RID: 84443
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
