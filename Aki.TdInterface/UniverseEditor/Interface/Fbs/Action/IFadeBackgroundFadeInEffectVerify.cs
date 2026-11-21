using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDE RID: 28126
	public static class IFadeBackgroundFadeInEffectVerify
	{
		// Token: 0x060308CE RID: 198862 RVA: 0x00697D1C File Offset: 0x00695F1C
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

		// Token: 0x020085D9 RID: 34265
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498D RID: 84365
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
