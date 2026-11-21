using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079DC RID: 31196
	public static class ISubScreenCustomInitDataVerify
	{
		// Token: 0x06036F77 RID: 225143 RVA: 0x00759498 File Offset: 0x00757698
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenCustomInitDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenCustomInitDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISubScreenConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200870C RID: 34572
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B30 RID: 84784
			public static VerifyTableAction <0>__Verify;
		}
	}
}
