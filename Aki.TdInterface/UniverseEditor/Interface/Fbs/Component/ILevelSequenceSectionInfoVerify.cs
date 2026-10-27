using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F3 RID: 21747
	public static class ILevelSequenceSectionInfoVerify
	{
		// Token: 0x06023E5C RID: 147036 RVA: 0x004F69CC File Offset: 0x004F4BCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyVectorOfStrings(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelSequenceSectionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelSequenceSectionInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B85 RID: 31621
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013608 RID: 79368
			public static VerifyTableAction <0>__Verify;
		}
	}
}
