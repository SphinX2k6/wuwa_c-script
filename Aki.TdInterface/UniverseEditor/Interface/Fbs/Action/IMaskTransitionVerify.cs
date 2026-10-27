using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A75 RID: 27253
	public static class IMaskTransitionVerify
	{
		// Token: 0x0602FBC6 RID: 195526 RVA: 0x0067EE08 File Offset: 0x0067D008
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMaskTransitionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMaskTransitionVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMaskTransitionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMaskTransitionVerify.<>O.<0>__Verify = new VerifyTableAction(IEaseDataVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DA2 RID: 32162
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401393A RID: 80186
			public static VerifyTableAction <0>__Verify;
		}
	}
}
