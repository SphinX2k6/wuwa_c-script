using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703C RID: 28732
	public static class IInteractFlowVerify
	{
		// Token: 0x06031CC5 RID: 203973 RVA: 0x006BDAAC File Offset: 0x006BBCAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008609 RID: 34313
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C9 RID: 84425
			public static VerifyTableAction <0>__Verify;
		}
	}
}
