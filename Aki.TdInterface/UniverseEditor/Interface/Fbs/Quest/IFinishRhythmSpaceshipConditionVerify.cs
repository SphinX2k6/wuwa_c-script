using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200427F RID: 17023
	public static class IFinishRhythmSpaceshipConditionVerify
	{
		// Token: 0x06017C12 RID: 97298 RVA: 0x0036382C File Offset: 0x00361A2C
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

		// Token: 0x02008128 RID: 33064
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141EC RID: 82412
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141ED RID: 82413
			public static VerifyTableAction <1>__Verify;
		}
	}
}
