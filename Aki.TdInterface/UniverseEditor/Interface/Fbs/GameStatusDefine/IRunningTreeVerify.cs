using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B76 RID: 19318
	public static class IRunningTreeVerify
	{
		// Token: 0x0601D657 RID: 120407 RVA: 0x00420AD4 File Offset: 0x0041ECD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunningTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunningTreeVerify.<>O.<0>__Verify = new VerifyTableAction(IRunningTreeConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008221 RID: 33313
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143E2 RID: 82914
			public static VerifyTableAction <0>__Verify;
		}
	}
}
