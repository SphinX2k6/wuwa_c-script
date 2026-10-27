using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF2 RID: 23282
	public static class ITriggerUe5ComponentVerify
	{
		// Token: 0x06027BEB RID: 162795 RVA: 0x00577908 File Offset: 0x00575B08
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

		// Token: 0x02007C6F RID: 31855
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401378F RID: 79759
			public static VerifyTableAction <0>__Verify;
		}
	}
}
