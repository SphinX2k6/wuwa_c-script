using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E44 RID: 15940
	public static class IFinishRhythmSpaceshipConditionVerify
	{
		// Token: 0x060165EB RID: 91627 RVA: 0x0033ACFC File Offset: 0x00338EFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishRhythmSpaceshipConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishRhythmSpaceshipConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFinishRhythmSpaceshipConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishRhythmSpaceshipConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IRhythmSpaceshipConditionStepInteractVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078E2 RID: 30946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401318E RID: 78222
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401318F RID: 78223
			public static VerifyTableAction <1>__Verify;
		}
	}
}
