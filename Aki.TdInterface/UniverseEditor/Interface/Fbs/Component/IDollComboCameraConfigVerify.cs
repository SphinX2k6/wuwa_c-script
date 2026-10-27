using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005095 RID: 20629
	public static class IDollComboCameraConfigVerify
	{
		// Token: 0x060211D0 RID: 135632 RVA: 0x00499DC0 File Offset: 0x00497FC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollComboCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollComboCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AD6 RID: 31446
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134DE RID: 79070
			public static VerifyTableAction <0>__Verify;
		}
	}
}
