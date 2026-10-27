using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB7 RID: 27575
	public static class INpcFollowConfigVerify
	{
		// Token: 0x06030718 RID: 198424 RVA: 0x006942C0 File Offset: 0x006924C0
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

		// Token: 0x02007DC7 RID: 32199
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401396B RID: 80235
			public static VerifyTableAction <0>__Verify;
		}
	}
}
