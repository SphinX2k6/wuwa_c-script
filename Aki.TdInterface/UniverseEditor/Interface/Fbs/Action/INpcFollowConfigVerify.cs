using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007303 RID: 29443
	public static class INpcFollowConfigVerify
	{
		// Token: 0x06033592 RID: 210322 RVA: 0x006ECC60 File Offset: 0x006EAE60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcFollowConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcFollowConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPerformerRangeBoundaryActionTriggerVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcFollowConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcFollowConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPerformerRangeBoundaryActionTriggerVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200864F RID: 34383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2B RID: 84523
			public static VerifyTableAction <0>__Verify;
		}
	}
}
