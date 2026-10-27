using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747A RID: 29818
	public static class ITriggerDialoguesVerify
	{
		// Token: 0x06036305 RID: 221957 RVA: 0x0075E21C File Offset: 0x0075C41C
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

		// Token: 0x02007EB1 RID: 32433
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF7 RID: 80887
			public static VerifyTableAction <0>__Verify;
		}
	}
}
