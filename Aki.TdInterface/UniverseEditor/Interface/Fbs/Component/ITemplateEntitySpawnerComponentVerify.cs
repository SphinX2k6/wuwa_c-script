using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A54 RID: 23124
	public static class ITemplateEntitySpawnerComponentVerify
	{
		// Token: 0x06027541 RID: 161089 RVA: 0x005693FC File Offset: 0x005675FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITemplateEntitySpawnerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITemplateEntitySpawnerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITemplateEntitySpawnerComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ITemplateEntitySpawnerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITemplateEntitySpawnerComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ITemplateEntitySpawnerComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ITemplateMatrixVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C56 RID: 31830
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401375D RID: 79709
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401375E RID: 79710
			public static VerifyTableAction <1>__Verify;
		}
	}
}
