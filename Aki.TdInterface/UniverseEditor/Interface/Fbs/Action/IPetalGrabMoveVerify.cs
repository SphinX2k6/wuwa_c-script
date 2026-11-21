using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007408 RID: 29704
	public static class IPetalGrabMoveVerify
	{
		// Token: 0x06033F9D RID: 212893 RVA: 0x00701A64 File Offset: 0x006FFC64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPetalGrabMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPetalGrabMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IPetalGrabMoveLinearVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008671 RID: 34417
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A5B RID: 84571
			public static VerifyTableAction <0>__Verify;
		}
	}
}
