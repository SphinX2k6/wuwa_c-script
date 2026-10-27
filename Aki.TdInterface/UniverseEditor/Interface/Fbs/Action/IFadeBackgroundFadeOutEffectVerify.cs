using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676D RID: 26477
	public static class IFadeBackgroundFadeOutEffectVerify
	{
		// Token: 0x0602E0F8 RID: 188664 RVA: 0x0064B18C File Offset: 0x0064938C
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

		// Token: 0x02007D63 RID: 32099
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E2 RID: 80098
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
