using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007354 RID: 29524
	public static class ITalkOptionSystemConditionVerify
	{
		// Token: 0x0603594D RID: 219469 RVA: 0x0074BF88 File Offset: 0x0074A188
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkOptionSystemConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkOptionSystemConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkOptionConditionSolarSchoolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E97 RID: 32407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BCF RID: 80847
			public static VerifyTableAction <0>__Verify;
		}
	}
}
