using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060CD RID: 24781
	public static class IActorInitialMontageVerify
	{
		// Token: 0x0602A503 RID: 173315 RVA: 0x005D4D5D File Offset: 0x005D2F5D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorInitialMontageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorInitialMontageVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CD2 RID: 31954
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013803 RID: 79875
			public static VerifyTableAction <0>__Verify;
		}
	}
}
