using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200584E RID: 22606
	public static class IRenderSpecifiedRangeComponentVerify
	{
		// Token: 0x060260CC RID: 155852 RVA: 0x0053F0F4 File Offset: 0x0053D2F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRenderSpecifiedRangeComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenderSpecifiedRangeComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRenderSpecifiedRangeComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRenderSpecifiedRangeComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TRenderSpecifiedRangeConfigVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C0A RID: 31754
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136DF RID: 79583
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040136E0 RID: 79584
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
