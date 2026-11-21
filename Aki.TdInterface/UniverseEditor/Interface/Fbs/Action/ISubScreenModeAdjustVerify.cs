using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E5 RID: 31205
	public static class ISubScreenModeAdjustVerify
	{
		// Token: 0x06036FB9 RID: 225209 RVA: 0x00759BCC File Offset: 0x00757DCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenModeAdjustVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenModeAdjustVerify.<>O.<0>__Verify = new VerifyTableAction(ISetSubScreenDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200870D RID: 34573
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B31 RID: 84785
			public static VerifyTableAction <0>__Verify;
		}
	}
}
