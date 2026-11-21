using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FAF RID: 20399
	public static class ICheckPlayerCanJoinActivityConditionVerify
	{
		// Token: 0x0601FCB2 RID: 130226 RVA: 0x0046ACC4 File Offset: 0x00468EC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerCanJoinActivityConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerCanJoinActivityConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckPlayerCanJoinRogueVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008291 RID: 33425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014473 RID: 83059
			public static VerifyTableAction <0>__Verify;
		}
	}
}
