using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046DE RID: 18142
	public static class IWaitBattleConditionVerify
	{
		// Token: 0x0601AACB RID: 109259 RVA: 0x003CAAD0 File Offset: 0x003C8CD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitBattleConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitBattleConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081C7 RID: 33223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014360 RID: 82784
			public static VerifyTableAction <0>__Verify;
		}
	}
}
