using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE3 RID: 27875
	public static class IPlayDynamicSettlementVerify
	{
		// Token: 0x0603126F RID: 201327 RVA: 0x006AB590 File Offset: 0x006A9790
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayDynamicSettlementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayDynamicSettlementVerify.<>O.<0>__Verify = new VerifyUnionAction(TDynamicSettlementConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF0 RID: 32240
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A4 RID: 80292
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
