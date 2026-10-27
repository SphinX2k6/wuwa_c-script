using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C93 RID: 19603
	public static class IPreChildQuestCondtionVerify
	{
		// Token: 0x0601F17E RID: 127358 RVA: 0x004583CC File Offset: 0x004565CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreChildQuestCondtionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreChildQuestCondtionVerify.<>O.<0>__Verify = new VerifyTableAction(IChildQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A65 RID: 31333
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401342D RID: 78893
			public static VerifyTableAction <0>__Verify;
		}
	}
}
