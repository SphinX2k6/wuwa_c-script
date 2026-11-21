using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E20 RID: 24096
	public static class IRefreshComponentVerify
	{
		// Token: 0x060283ED RID: 164845 RVA: 0x00580DDC File Offset: 0x0057EFDC
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

		// Token: 0x02008470 RID: 33904
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014773 RID: 83827
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
