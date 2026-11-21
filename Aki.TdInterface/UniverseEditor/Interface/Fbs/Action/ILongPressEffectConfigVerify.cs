using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715F RID: 29023
	public static class ILongPressEffectConfigVerify
	{
		// Token: 0x060326D9 RID: 206553 RVA: 0x006D0BC4 File Offset: 0x006CEDC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILongPressEffectConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILongPressEffectConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IGamePadInteractVibrationVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200861E RID: 34334
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E8 RID: 84456
			public static VerifyTableAction <0>__Verify;
		}
	}
}
