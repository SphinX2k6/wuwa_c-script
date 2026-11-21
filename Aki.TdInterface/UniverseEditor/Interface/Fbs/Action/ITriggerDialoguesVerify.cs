using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C6D RID: 31853
	public static class ITriggerDialoguesVerify
	{
		// Token: 0x060396EE RID: 235246 RVA: 0x007C0F48 File Offset: 0x007BF148
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerDialoguesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerDialoguesVerify.<>O.<0>__Verify = new VerifyTableAction(IFocusObjectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200874B RID: 34635
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD1 RID: 85201
			public static VerifyTableAction <0>__Verify;
		}
	}
}
