using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DED RID: 28141
	public static class IFadeBackgroundFadeOutEffectVerify
	{
		// Token: 0x0603093E RID: 198974 RVA: 0x006988D0 File Offset: 0x00696AD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFadeBackgroundFadeOutEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeBackgroundFadeOutEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TFadeBackgroundFadeOutEffectVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085DA RID: 34266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498E RID: 84366
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
