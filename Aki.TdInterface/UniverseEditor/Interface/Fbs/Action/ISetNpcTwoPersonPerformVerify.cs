using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007045 RID: 28741
	public static class ISetNpcTwoPersonPerformVerify
	{
		// Token: 0x06032DB1 RID: 208305 RVA: 0x006DC000 File Offset: 0x006DA200
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

		// Token: 0x02007E48 RID: 32328
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A13 RID: 80403
			public static VerifyTableAction <0>__Verify;
		}
	}
}
