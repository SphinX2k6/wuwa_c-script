using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DD2 RID: 15826
	public static class IDetectCombatStateConditionVerify
	{
		// Token: 0x06016196 RID: 90518 RVA: 0x00331CBC File Offset: 0x0032FEBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDetectCombatStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDetectCombatStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D1 RID: 30929
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013173 RID: 78195
			public static VerifyTableAction <0>__Verify;
		}
	}
}
