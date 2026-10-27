using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x0200470E RID: 18190
	public static class IRunningTreeVerify
	{
		// Token: 0x0601BE82 RID: 114306 RVA: 0x003F4838 File Offset: 0x003F2A38
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

		// Token: 0x020079D8 RID: 31192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401337B RID: 78715
			public static VerifyTableAction <0>__Verify;
		}
	}
}
