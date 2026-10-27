using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4E RID: 23118
	public static class ITeleportComponentVerify
	{
		// Token: 0x06027505 RID: 161029 RVA: 0x00568C78 File Offset: 0x00566E78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IGravityFlipTeleportConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C55 RID: 31829
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401375B RID: 79707
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401375C RID: 79708
			public static VerifyTableAction <1>__Verify;
		}
	}
}
