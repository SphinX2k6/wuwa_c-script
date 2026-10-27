using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A1A RID: 18970
	public static class ICheckEntitySelfDirectionVerify
	{
		// Token: 0x0601DAF4 RID: 121588 RVA: 0x0042D254 File Offset: 0x0042B454
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEntitySelfDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntitySelfDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A2E RID: 31278
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F2 RID: 78834
			public static VerifyTableAction <0>__Verify;
		}
	}
}
