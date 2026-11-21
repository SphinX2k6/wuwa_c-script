using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BD RID: 18109
	public static class IUseWeatherSwitchConditionVerify
	{
		// Token: 0x0601A9D6 RID: 109014 RVA: 0x003C8F70 File Offset: 0x003C7170
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUseWeatherSwitchConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseWeatherSwitchConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IUseWeatherSwitchConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IUseWeatherSwitchConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TUseWeatherSwitchConditionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081C5 RID: 33221
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401435C RID: 82780
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401435D RID: 82781
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
