using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006403 RID: 25603
	public static class IGiantResponsePlayFlowVerify
	{
		// Token: 0x0602B7F9 RID: 178169 RVA: 0x005ECBE0 File Offset: 0x005EADE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantResponsePlayFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantResponsePlayFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantFlowConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008519 RID: 34073
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401487B RID: 84091
			public static VerifyTableAction <0>__Verify;
		}
	}
}
