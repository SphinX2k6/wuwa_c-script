using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C0 RID: 22208
	public static class IEntityBatchRefreshComponentVerify
	{
		// Token: 0x06023963 RID: 145763 RVA: 0x004E4CB0 File Offset: 0x004E2EB0
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

		// Token: 0x0200834F RID: 33615
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014592 RID: 83346
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014593 RID: 83347
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
