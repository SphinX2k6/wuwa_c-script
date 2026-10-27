using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E57 RID: 28247
	public static class IRemovePreloadFlowsVerify
	{
		// Token: 0x06031EA3 RID: 204451 RVA: 0x006C0E40 File Offset: 0x006BF040
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

		// Token: 0x02007E0E RID: 32270
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C9 RID: 80329
			public static VerifyTableAction <0>__Verify;
		}
	}
}
