using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675E RID: 26462
	public static class IFadeBackgroundFadeInEffectVerify
	{
		// Token: 0x0602E088 RID: 188552 RVA: 0x0064A5D8 File Offset: 0x006487D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFadeBackgroundFadeInEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFadeBackgroundFadeInEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TFadeBackgroundFadeInEffectVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D62 RID: 32098
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E1 RID: 80097
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
