using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515B RID: 20827
	public static class IEntityBatchRefreshComponentVerify
	{
		// Token: 0x06021A0F RID: 137743 RVA: 0x004AAD24 File Offset: 0x004A8F24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityBatchRefreshComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityBatchRefreshComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityBatchRefreshComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IEntityBatchRefreshComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short typeIdVOffset = 10;
						short valueVOffset = 12;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IEntityBatchRefreshComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IEntityBatchRefreshComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TEntityBatchRefreshVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AF5 RID: 31477
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013514 RID: 79124
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013515 RID: 79125
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
