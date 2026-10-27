using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DFC RID: 15868
	public static class IEnterDungeonConditionVerify
	{
		// Token: 0x06016320 RID: 90912 RVA: 0x00334974 File Offset: 0x00332B74
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

		// Token: 0x020078D5 RID: 30933
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013178 RID: 78200
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013179 RID: 78201
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
