using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B73 RID: 23411
	public static class IWellStreamingRenderConfigVerify
	{
		// Token: 0x06028116 RID: 164118 RVA: 0x005821D4 File Offset: 0x005803D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWellStreamingRenderConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWellStreamingRenderConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IWellStreamingRenderSelfConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWellStreamingRenderConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWellStreamingRenderConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IWellStreamingRenderPointConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C7E RID: 31870
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A5 RID: 79781
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137A6 RID: 79782
			public static VerifyTableAction <1>__Verify;
		}
	}
}
