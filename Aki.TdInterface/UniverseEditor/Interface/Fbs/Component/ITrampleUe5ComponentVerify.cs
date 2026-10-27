using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD7 RID: 23255
	public static class ITrampleUe5ComponentVerify
	{
		// Token: 0x06027A99 RID: 162457 RVA: 0x00574A94 File Offset: 0x00572C94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrampleUe5ComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrampleUe5ComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrampleUe5ComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ITrampleUe5ComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C6A RID: 31850
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013785 RID: 79749
			public static VerifyTableAction <0>__Verify;
		}
	}
}
