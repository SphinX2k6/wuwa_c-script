using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005549 RID: 21833
	public static class IConditionalStreamingSourceVerify
	{
		// Token: 0x06022A3E RID: 141886 RVA: 0x004C567C File Offset: 0x004C387C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionalStreamingSourceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionalStreamingSourceVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionalStreamingSourceConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008315 RID: 33557
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014529 RID: 83241
			public static VerifyTableAction <0>__Verify;
		}
	}
}
