using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006189 RID: 24969
	public static class IWellStreamingRenderConfigVerify
	{
		// Token: 0x0602A6DA RID: 173786 RVA: 0x005C9C64 File Offset: 0x005C7E64
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

		// Token: 0x020084EF RID: 34031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401484B RID: 84043
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401484C RID: 84044
			public static VerifyTableAction <1>__Verify;
		}
	}
}
