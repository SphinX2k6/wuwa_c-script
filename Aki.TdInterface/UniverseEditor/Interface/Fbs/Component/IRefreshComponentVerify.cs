using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005819 RID: 22553
	public static class IRefreshComponentVerify
	{
		// Token: 0x06025ECD RID: 155341 RVA: 0x0053AC50 File Offset: 0x00538E50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRefreshComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRefreshComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TRefreshRuleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C02 RID: 31746
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D3 RID: 79571
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
