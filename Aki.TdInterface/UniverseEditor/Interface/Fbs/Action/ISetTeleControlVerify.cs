using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708A RID: 28810
	public static class ISetTeleControlVerify
	{
		// Token: 0x06033040 RID: 208960 RVA: 0x006E1B10 File Offset: 0x006DFD10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetTeleControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTeleControlVerify.<>O.<0>__Verify = new VerifyUnionAction(TSetTeleControlConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E54 RID: 32340
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A2B RID: 80427
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
