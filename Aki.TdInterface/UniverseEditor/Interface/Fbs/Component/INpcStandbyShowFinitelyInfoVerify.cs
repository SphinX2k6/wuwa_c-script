using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565E RID: 22110
	public static class INpcStandbyShowFinitelyInfoVerify
	{
		// Token: 0x06024C3E RID: 150590 RVA: 0x0051290C File Offset: 0x00510B0C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcStandbyShowFinitelyInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcStandbyShowFinitelyInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcStandbyShowFinitelyInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcStandbyShowFinitelyInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IIgnoreEntityIdsCollisionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BB1 RID: 31665
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013656 RID: 79446
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013657 RID: 79447
			public static VerifyTableAction <1>__Verify;
		}
	}
}
