using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3D RID: 27197
	public static class ILongPressEffectConfigVerify
	{
		// Token: 0x0602F9B3 RID: 194995 RVA: 0x0067AB04 File Offset: 0x00678D04
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

		// Token: 0x02007D9B RID: 32155
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401392F RID: 80175
			public static VerifyTableAction <0>__Verify;
		}
	}
}
