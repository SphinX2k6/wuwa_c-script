using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006061 RID: 24673
	public static class ITemplateEntitySpawnerComponentVerify
	{
		// Token: 0x06029AB9 RID: 170681 RVA: 0x005B0408 File Offset: 0x005AE608
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

		// Token: 0x020084C5 RID: 33989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014801 RID: 83969
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014802 RID: 83970
			public static VerifyTableAction <1>__Verify;
		}
	}
}
