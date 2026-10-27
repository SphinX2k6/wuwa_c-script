using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CDA RID: 27866
	public static class IPlayCommonEffectVerify
	{
		// Token: 0x060311FF RID: 201215 RVA: 0x006AA700 File Offset: 0x006A8900
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayCommonEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayCommonEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TEffectPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DEE RID: 32238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A2 RID: 80290
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
