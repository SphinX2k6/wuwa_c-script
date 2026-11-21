using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2B RID: 27179
	public static class IClientEventUiPlayPianoVerify
	{
		// Token: 0x0602EA02 RID: 190978 RVA: 0x0065B74C File Offset: 0x0065994C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientEventUiPlayPianoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventUiPlayPianoVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientEventPianoEventVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008591 RID: 34193
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014932 RID: 84274
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
