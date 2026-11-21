using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704E RID: 28750
	public static class IInteractPointVerify
	{
		// Token: 0x06031DB8 RID: 204216 RVA: 0x006BFF00 File Offset: 0x006BE100
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractPointVerify.<>O.<0>__Verify = new VerifyTableAction(IDragInteractPointInteractionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200860C RID: 34316
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D2 RID: 84434
			public static VerifyTableAction <0>__Verify;
		}
	}
}
