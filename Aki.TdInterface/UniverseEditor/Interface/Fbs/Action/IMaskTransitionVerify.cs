using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007197 RID: 29079
	public static class IMaskTransitionVerify
	{
		// Token: 0x060328EC RID: 207084 RVA: 0x006D4EC8 File Offset: 0x006D30C8
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

		// Token: 0x02008625 RID: 34341
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149F3 RID: 84467
			public static VerifyTableAction <0>__Verify;
		}
	}
}
