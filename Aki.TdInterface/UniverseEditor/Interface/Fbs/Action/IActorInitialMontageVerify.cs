using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672F RID: 26415
	public static class IActorInitialMontageVerify
	{
		// Token: 0x0602CBE4 RID: 183268 RVA: 0x0061ED05 File Offset: 0x0061CF05
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

		// Token: 0x02008543 RID: 34115
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A9 RID: 84137
			public static VerifyTableAction <0>__Verify;
		}
	}
}
