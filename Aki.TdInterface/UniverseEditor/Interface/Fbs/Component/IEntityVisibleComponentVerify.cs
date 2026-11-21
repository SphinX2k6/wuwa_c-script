using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200572C RID: 22316
	public static class IEntityVisibleComponentVerify
	{
		// Token: 0x06023E5B RID: 147035 RVA: 0x004EF494 File Offset: 0x004ED694
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityVisibleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityVisibleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVisibleConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008363 RID: 33635
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B1 RID: 83377
			public static VerifyTableAction <0>__Verify;
		}
	}
}
