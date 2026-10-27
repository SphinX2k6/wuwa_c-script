using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA4 RID: 23204
	public static class ITimeScheduleGenerateDynamicEntityVerify
	{
		// Token: 0x06027899 RID: 161945 RVA: 0x005706E0 File Offset: 0x0056E8E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleGenerateDynamicEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleGenerateDynamicEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleGenerateParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeScheduleGenerateDynamicEntityVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimeScheduleGenerateDynamicEntityVerify.<>O.<1>__Verify = new VerifyTableAction(ITimeScheduleEntityTemplateNpcSourceVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITimeScheduleGenerateDynamicEntityVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITimeScheduleGenerateDynamicEntityVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C64 RID: 31844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013776 RID: 79734
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013777 RID: 79735
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013778 RID: 79736
			public static VerifyTableAction <2>__Verify;
		}
	}
}
