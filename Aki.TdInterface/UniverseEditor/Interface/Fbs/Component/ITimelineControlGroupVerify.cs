using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7B RID: 23163
	public static class ITimelineControlGroupVerify
	{
		// Token: 0x0602773A RID: 161594 RVA: 0x0056DBF8 File Offset: 0x0056BDF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimelineControlGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimelineControlGroupVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimelineControlGroupVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimelineControlGroupVerify.<>O.<1>__Verify = new VerifyTableAction(IControlPointEventConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C5E RID: 31838
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401376E RID: 79726
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401376F RID: 79727
			public static VerifyTableAction <1>__Verify;
		}
	}
}
