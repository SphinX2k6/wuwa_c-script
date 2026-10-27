using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B4C RID: 19276
	public static class ICheckTargetAttributeConditionVerify
	{
		// Token: 0x0601E5A6 RID: 124326 RVA: 0x00440AA8 File Offset: 0x0043ECA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckTargetAttributeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetAttributeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerAttributeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckTargetAttributeConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckTargetAttributeConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A4C RID: 31308
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013412 RID: 78866
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013413 RID: 78867
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
