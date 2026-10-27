using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004454 RID: 17492
	public static class IDaemonHackCodeMatrixVerify
	{
		// Token: 0x0601A09D RID: 106653 RVA: 0x003B8998 File Offset: 0x003B6B98
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

		// Token: 0x0200799B RID: 31131
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401331F RID: 78623
			public static VerifyTableAction <0>__Verify;
		}
	}
}
