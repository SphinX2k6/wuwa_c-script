using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE6 RID: 27878
	public static class IPlayEffectVerify
	{
		// Token: 0x0603128E RID: 201358 RVA: 0x006ABA48 File Offset: 0x006A9C48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TPos2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF1 RID: 32241
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A5 RID: 80293
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
