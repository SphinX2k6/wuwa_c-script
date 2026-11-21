using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048BC RID: 18620
	public static class IDaemonHackCodeMatrixVerify
	{
		// Token: 0x0601B86E RID: 112750 RVA: 0x003E4BA4 File Offset: 0x003E2DA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDaemonHackCodeMatrixVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDaemonHackCodeMatrixVerify.<>O.<0>__Verify = new VerifyTableAction(IDaemonHackPresetCodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081E4 RID: 33252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014386 RID: 82822
			public static VerifyTableAction <0>__Verify;
		}
	}
}
