using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005390 RID: 21392
	public static class IAiGearStrategyComponentVerify
	{
		// Token: 0x060215CC RID: 136652 RVA: 0x0049A9B4 File Offset: 0x00498BB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAiGearStrategyComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiGearStrategyComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAiGearStrategyVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082CA RID: 33482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144B8 RID: 83128
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
