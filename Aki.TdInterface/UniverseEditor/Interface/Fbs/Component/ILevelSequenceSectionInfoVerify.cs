using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A79 RID: 23161
	public static class ILevelSequenceSectionInfoVerify
	{
		// Token: 0x06025F16 RID: 155414 RVA: 0x00533AF0 File Offset: 0x00531CF0
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

		// Token: 0x020083E4 RID: 33764
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401468E RID: 83598
			public static VerifyTableAction <0>__Verify;
		}
	}
}
