using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007811 RID: 30737
	public static class ISetNpcTwoPersonPerformVerify
	{
		// Token: 0x0603604E RID: 221262 RVA: 0x0073C528 File Offset: 0x0073A728
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcTwoPersonPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcTwoPersonPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086DE RID: 34526
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE7 RID: 84711
			public static VerifyTableAction <0>__Verify;
		}
	}
}
