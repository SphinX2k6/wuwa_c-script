using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200402A RID: 16426
	public static class IQuestScheduleMeetConditionVerify
	{
		// Token: 0x06017C0F RID: 97295 RVA: 0x0036D458 File Offset: 0x0036B658
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleMeetConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleMeetConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007938 RID: 31032
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401324B RID: 78411
			public static VerifyTableAction <0>__Verify;
		}
	}
}
