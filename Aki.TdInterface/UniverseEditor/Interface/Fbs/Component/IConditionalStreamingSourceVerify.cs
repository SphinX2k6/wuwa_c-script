using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FEA RID: 20458
	public static class IConditionalStreamingSourceVerify
	{
		// Token: 0x06020B1E RID: 133918 RVA: 0x0048BC2C File Offset: 0x00489E2C
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

		// Token: 0x02007ABB RID: 31419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134AB RID: 79019
			public static VerifyTableAction <0>__Verify;
		}
	}
}
