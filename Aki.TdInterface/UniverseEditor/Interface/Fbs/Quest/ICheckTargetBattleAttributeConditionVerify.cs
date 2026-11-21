using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418C RID: 16780
	public static class ICheckTargetBattleAttributeConditionVerify
	{
		// Token: 0x060171BE RID: 94654 RVA: 0x0034B2AC File Offset: 0x003494AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckTargetBattleAttributeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetBattleAttributeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008102 RID: 33026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014195 RID: 82325
			public static VerifyTableAction <0>__Verify;
		}
	}
}
