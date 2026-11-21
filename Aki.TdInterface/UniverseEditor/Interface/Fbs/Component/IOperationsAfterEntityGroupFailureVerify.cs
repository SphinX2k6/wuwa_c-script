using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C50 RID: 23632
	public static class IOperationsAfterEntityGroupFailureVerify
	{
		// Token: 0x060272EA RID: 160490 RVA: 0x0055E198 File Offset: 0x0055C398
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

		// Token: 0x02008426 RID: 33830
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014704 RID: 83716
			public static VerifyTableAction <0>__Verify;
		}
	}
}
