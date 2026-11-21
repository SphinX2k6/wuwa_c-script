using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E3E RID: 20030
	public static class ICheckAtlasUnlockedVerify
	{
		// Token: 0x0601EFB2 RID: 126898 RVA: 0x004539E8 File Offset: 0x00451BE8
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

		// Token: 0x0200826E RID: 33390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401444F RID: 83023
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
