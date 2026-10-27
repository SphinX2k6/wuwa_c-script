using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007246 RID: 29254
	public static class ISuperCatapultVerify
	{
		// Token: 0x06033E2F RID: 212527 RVA: 0x006FAE24 File Offset: 0x006F9024
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISuperCatapultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISuperCatapultVerify.<>O.<0>__Verify = new VerifyTableAction(ICatapultParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E79 RID: 32377
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5D RID: 80477
			public static VerifyTableAction <0>__Verify;
		}
	}
}
