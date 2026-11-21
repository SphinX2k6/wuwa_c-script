using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EB RID: 17131
	public static class IInformationViewConfigVerify
	{
		// Token: 0x060180DF RID: 98527 RVA: 0x0036EA88 File Offset: 0x0036CC88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInformationViewConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInformationViewConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TInformationViewVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200813D RID: 33085
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014212 RID: 82450
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
