using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A1B RID: 31259
	public static class ISuperCatapultVerify
	{
		// Token: 0x06037131 RID: 225585 RVA: 0x0075C184 File Offset: 0x0075A384
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

		// Token: 0x02008710 RID: 34576
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B34 RID: 84788
			public static VerifyTableAction <0>__Verify;
		}
	}
}
