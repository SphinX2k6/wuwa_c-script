using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063BA RID: 25530
	public static class IClientEventUiPlayPianoVerify
	{
		// Token: 0x0602C2A0 RID: 180896 RVA: 0x00610714 File Offset: 0x0060E914
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

		// Token: 0x02007D1D RID: 32029
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013888 RID: 80008
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
