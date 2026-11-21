using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004237 RID: 16951
	public static class IEnterDungeonConditionVerify
	{
		// Token: 0x0601794D RID: 96589 RVA: 0x0035D56C File Offset: 0x0035B76C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnterDungeonConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnterDungeonConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IEnterDungeonConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEnterDungeonConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TEnterDungeonVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200811B RID: 33051
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141D6 RID: 82390
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141D7 RID: 82391
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
