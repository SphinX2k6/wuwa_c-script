using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052B4 RID: 21172
	public static class IFollowTrackToFoundationVerify
	{
		// Token: 0x06022850 RID: 141392 RVA: 0x004C8E4C File Offset: 0x004C704C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowTrackToFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowTrackToFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B30 RID: 31536
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401356E RID: 79214
			public static VerifyTableAction <0>__Verify;
		}
	}
}
