using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E89 RID: 20105
	public static class ICheckDirectionConditionVerify
	{
		// Token: 0x0601F258 RID: 127576 RVA: 0x0045820C File Offset: 0x0045640C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckDirectionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckDirectionConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008273 RID: 33395
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014454 RID: 83028
			public static VerifyTableAction <0>__Verify;
		}
	}
}
