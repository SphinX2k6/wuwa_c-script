using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004243 RID: 16963
	public static class IUseItemConditionVerify
	{
		// Token: 0x0601916A RID: 102762 RVA: 0x0039BA14 File Offset: 0x00399C14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUseItemConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseItemConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007979 RID: 31097
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F1 RID: 78577
			public static VerifyTableAction <0>__Verify;
		}
	}
}
