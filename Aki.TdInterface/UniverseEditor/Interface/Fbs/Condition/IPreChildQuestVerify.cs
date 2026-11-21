using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005189 RID: 20873
	public static class IPreChildQuestVerify
	{
		// Token: 0x06020D8A RID: 134538 RVA: 0x0048BC80 File Offset: 0x00489E80
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

		// Token: 0x020082B6 RID: 33462
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401449C RID: 83100
			public static VerifyTableAction <0>__Verify;
		}
	}
}
