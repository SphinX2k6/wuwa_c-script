using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063CF RID: 25551
	public static class IClientGroupAiCommunicateVerify
	{
		// Token: 0x0602C330 RID: 181040 RVA: 0x00611644 File Offset: 0x0060F844
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientGroupAiCommunicateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientGroupAiCommunicateVerify.<>O.<0>__Verify = new VerifyUnionAction(TGroupAiCommunicateOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D1F RID: 32031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401388A RID: 80010
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
