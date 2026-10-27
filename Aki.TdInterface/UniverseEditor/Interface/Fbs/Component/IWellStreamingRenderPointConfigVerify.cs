using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B76 RID: 23414
	public static class IWellStreamingRenderPointConfigVerify
	{
		// Token: 0x06028140 RID: 164160 RVA: 0x0058274C File Offset: 0x0058094C
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

		// Token: 0x02007C7F RID: 31871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A7 RID: 79783
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137A8 RID: 79784
			public static VerifyTableAction <1>__Verify;
		}
	}
}
