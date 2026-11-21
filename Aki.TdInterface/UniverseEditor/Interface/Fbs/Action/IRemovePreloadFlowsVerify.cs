using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D8 RID: 30168
	public static class IRemovePreloadFlowsVerify
	{
		// Token: 0x06034ECB RID: 216779 RVA: 0x0071C940 File Offset: 0x0071AB40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRemovePreloadFlowsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRemovePreloadFlowsVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200869A RID: 34458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A8D RID: 84621
			public static VerifyTableAction <0>__Verify;
		}
	}
}
