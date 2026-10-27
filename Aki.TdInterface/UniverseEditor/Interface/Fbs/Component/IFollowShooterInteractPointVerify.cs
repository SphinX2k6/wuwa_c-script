using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052A5 RID: 21157
	public static class IFollowShooterInteractPointVerify
	{
		// Token: 0x060227D3 RID: 141267 RVA: 0x004C7FFC File Offset: 0x004C61FC
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

		// Token: 0x02007B2E RID: 31534
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401356C RID: 79212
			public static VerifyTableAction <0>__Verify;
		}
	}
}
