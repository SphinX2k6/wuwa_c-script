using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774F RID: 30543
	public static class ISequenceUnlockPointsVerify
	{
		// Token: 0x060359A7 RID: 219559 RVA: 0x0072F45C File Offset: 0x0072D65C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceUnlockPointsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceUnlockPointsVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceInteractStageVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086BE RID: 34494
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB7 RID: 84663
			public static VerifyTableAction <0>__Verify;
		}
	}
}
