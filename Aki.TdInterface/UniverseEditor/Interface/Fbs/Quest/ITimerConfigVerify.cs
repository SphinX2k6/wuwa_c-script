using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004633 RID: 17971
	public static class ITimerConfigVerify
	{
		// Token: 0x0601A4CC RID: 107724 RVA: 0x003BE42C File Offset: 0x003BC62C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITimerConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimerConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimerConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimerConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ITimerUiConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081B2 RID: 33202
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401432F RID: 82735
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014330 RID: 82736
			public static VerifyTableAction <1>__Verify;
		}
	}
}
