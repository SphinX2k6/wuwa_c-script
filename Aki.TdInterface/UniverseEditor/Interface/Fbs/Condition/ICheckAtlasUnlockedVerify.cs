using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004987 RID: 18823
	public static class ICheckAtlasUnlockedVerify
	{
		// Token: 0x0601D58D RID: 120205 RVA: 0x00423534 File Offset: 0x00421734
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckAtlasUnlockedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckAtlasUnlockedVerify.<>O.<0>__Verify = new VerifyUnionAction(TUnlockAtlasSystemOptionV2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A1F RID: 31263
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E2 RID: 78818
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
