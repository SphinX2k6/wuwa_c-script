using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A4 RID: 26532
	public static class IAddTrialFollowShooterVerify
	{
		// Token: 0x0602D087 RID: 184455 RVA: 0x00627D30 File Offset: 0x00625F30
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

		// Token: 0x02008551 RID: 34129
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148BD RID: 84157
			public static VerifyTableAction <0>__Verify;
		}
	}
}
