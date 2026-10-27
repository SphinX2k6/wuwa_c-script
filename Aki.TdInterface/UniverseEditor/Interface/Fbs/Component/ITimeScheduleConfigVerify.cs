using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A95 RID: 23189
	public static class ITimeScheduleConfigVerify
	{
		// Token: 0x06027833 RID: 161843 RVA: 0x0056FBA8 File Offset: 0x0056DDA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleGenerateDynamicEntityVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeScheduleConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimeScheduleConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C63 RID: 31843
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013774 RID: 79732
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013775 RID: 79733
			public static VerifyTableAction <1>__Verify;
		}
	}
}
