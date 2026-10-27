using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703F RID: 28735
	public static class ISetNpcHuggingBearPerformVerify
	{
		// Token: 0x06032D6B RID: 208235 RVA: 0x006DB788 File Offset: 0x006D9988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcHuggingBearPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcHuggingBearPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E46 RID: 32326
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A11 RID: 80401
			public static VerifyTableAction <0>__Verify;
		}
	}
}
