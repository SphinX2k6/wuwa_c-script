using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C90 RID: 19600
	public static class IPreChildQuestVerify
	{
		// Token: 0x0601F168 RID: 127336 RVA: 0x00458130 File Offset: 0x00456330
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreChildQuestVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreChildQuestVerify.<>O.<0>__Verify = new VerifyTableAction(IChildQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A64 RID: 31332
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401342C RID: 78892
			public static VerifyTableAction <0>__Verify;
		}
	}
}
