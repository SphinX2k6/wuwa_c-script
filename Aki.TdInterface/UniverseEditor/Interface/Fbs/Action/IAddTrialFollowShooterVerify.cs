using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613F RID: 24895
	public static class IAddTrialFollowShooterVerify
	{
		// Token: 0x0602A98E RID: 174478 RVA: 0x005DDB54 File Offset: 0x005DBD54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddTrialFollowShooterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddTrialFollowShooterVerify.<>O.<0>__Verify = new VerifyTableAction(IActiveRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CE0 RID: 31968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013817 RID: 79895
			public static VerifyTableAction <0>__Verify;
		}
	}
}
