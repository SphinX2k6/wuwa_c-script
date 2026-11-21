using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF0 RID: 24048
	public static class IRandomInteractVerify
	{
		// Token: 0x06028239 RID: 164409 RVA: 0x0057D574 File Offset: 0x0057B774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IRandomInteractOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008467 RID: 33895
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014766 RID: 83814
			public static VerifyTableAction <0>__Verify;
		}
	}
}
