using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774C RID: 30540
	public static class ISequenceInteractStageVerify
	{
		// Token: 0x0603598B RID: 219531 RVA: 0x0072F084 File Offset: 0x0072D284
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceInteractStageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceInteractStageVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086BD RID: 34493
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB6 RID: 84662
			public static VerifyTableAction <0>__Verify;
		}
	}
}
