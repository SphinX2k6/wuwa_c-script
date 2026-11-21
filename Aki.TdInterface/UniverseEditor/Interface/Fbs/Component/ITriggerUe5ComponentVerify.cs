using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060FF RID: 24831
	public static class ITriggerUe5ComponentVerify
	{
		// Token: 0x0602A177 RID: 172407 RVA: 0x005BEDCC File Offset: 0x005BCFCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerUe5ComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerUe5ComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITriggerActionsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084DF RID: 34015
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014834 RID: 84020
			public static VerifyTableAction <0>__Verify;
		}
	}
}
