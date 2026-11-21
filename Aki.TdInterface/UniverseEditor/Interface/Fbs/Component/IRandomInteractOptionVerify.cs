using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DF3 RID: 24051
	public static class IRandomInteractOptionVerify
	{
		// Token: 0x0602824F RID: 164431 RVA: 0x0057D800 File Offset: 0x0057BA00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008468 RID: 33896
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014767 RID: 83815
			public static VerifyTableAction <0>__Verify;
		}
	}
}
