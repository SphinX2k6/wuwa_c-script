using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4C RID: 20044
	public static class IActivateSpecifiedPieceVerify
	{
		// Token: 0x0601F759 RID: 128857 RVA: 0x00461F74 File Offset: 0x00460174
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActivateSpecifiedPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActivateSpecifiedPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IActivateSpecifiedPieceConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A6D RID: 31341
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013439 RID: 78905
			public static VerifyTableAction <0>__Verify;
		}
	}
}
