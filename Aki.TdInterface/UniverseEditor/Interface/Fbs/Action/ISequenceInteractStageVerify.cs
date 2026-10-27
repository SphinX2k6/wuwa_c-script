using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F86 RID: 28550
	public static class ISequenceInteractStageVerify
	{
		// Token: 0x0603273B RID: 206651 RVA: 0x006CF6CC File Offset: 0x006CD8CC
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

		// Token: 0x02007E29 RID: 32297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E6 RID: 80358
			public static VerifyTableAction <0>__Verify;
		}
	}
}
