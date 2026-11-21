using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580D RID: 22541
	public static class IFollowShooterInteractPointVerify
	{
		// Token: 0x0602476D RID: 149357 RVA: 0x00502B6C File Offset: 0x00500D6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowShooterInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowShooterInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IThrowFollowShooterInteractConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008389 RID: 33673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145EC RID: 83436
			public static VerifyTableAction <0>__Verify;
		}
	}
}
