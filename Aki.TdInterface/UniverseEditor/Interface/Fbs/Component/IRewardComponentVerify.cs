using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005869 RID: 22633
	public static class IRewardComponentVerify
	{
		// Token: 0x0602621E RID: 156190 RVA: 0x00541FE0 File Offset: 0x005401E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRewardComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRewardComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IRewardRefreshConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C0F RID: 31759
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E7 RID: 79591
			public static VerifyTableAction <0>__Verify;
		}
	}
}
