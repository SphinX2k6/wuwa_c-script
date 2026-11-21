using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AE RID: 24750
	public static class ITimeScheduleGenerateDynamicEntityVerify
	{
		// Token: 0x06029E1B RID: 171547 RVA: 0x005B7ACC File Offset: 0x005B5CCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleGenerateDynamicEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleGenerateDynamicEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleFixedIntervalRefreshVerify.Verify));
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

		// Token: 0x020084D5 RID: 34005
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401481D RID: 83997
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401481E RID: 83998
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401481F RID: 83999
			public static VerifyTableAction <2>__Verify;
		}
	}
}
