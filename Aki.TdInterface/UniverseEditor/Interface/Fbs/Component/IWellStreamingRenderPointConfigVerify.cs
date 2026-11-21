using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618C RID: 24972
	public static class IWellStreamingRenderPointConfigVerify
	{
		// Token: 0x0602A704 RID: 173828 RVA: 0x005CA1DC File Offset: 0x005C83DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWellStreamingRenderPointConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWellStreamingRenderPointConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWellStreamingRenderPointConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWellStreamingRenderPointConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IRtSizeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084F0 RID: 34032
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401484D RID: 84045
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401484E RID: 84046
			public static VerifyTableAction <1>__Verify;
		}
	}
}
