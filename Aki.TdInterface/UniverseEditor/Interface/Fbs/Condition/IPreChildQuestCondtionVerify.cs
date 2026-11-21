using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200518C RID: 20876
	public static class IPreChildQuestCondtionVerify
	{
		// Token: 0x06020DA0 RID: 134560 RVA: 0x0048BF1C File Offset: 0x0048A11C
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

		// Token: 0x020082B7 RID: 33463
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401449D RID: 83101
			public static VerifyTableAction <0>__Verify;
		}
	}
}
