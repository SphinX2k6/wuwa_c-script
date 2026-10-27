using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AC RID: 22188
	public static class IOperationsAfterEntityGroupFailureVerify
	{
		// Token: 0x06025095 RID: 151701 RVA: 0x0051D250 File Offset: 0x0051B450
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOperationsAfterEntityGroupFailureVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOperationsAfterEntityGroupFailureVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BC3 RID: 31683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013674 RID: 79476
			public static VerifyTableAction <0>__Verify;
		}
	}
}
