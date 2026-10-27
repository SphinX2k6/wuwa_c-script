using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFC RID: 27644
	public static class IOpenFishingItemDeliveryWithReturnVerify
	{
		// Token: 0x0603098A RID: 199050 RVA: 0x00698BCC File Offset: 0x00696DCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenFishingItemDeliveryWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenFishingItemDeliveryWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DCF RID: 32207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013973 RID: 80243
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
