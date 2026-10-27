using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E4 RID: 16612
	public static class IRoleTowerSystemConfigVerify
	{
		// Token: 0x0601834F RID: 99151 RVA: 0x0037C5CC File Offset: 0x0037A7CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRoleTowerSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleTowerSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRoleTowerSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200794D RID: 31053
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401326E RID: 78446
			public static VerifyTableAction <0>__Verify;
		}
	}
}
