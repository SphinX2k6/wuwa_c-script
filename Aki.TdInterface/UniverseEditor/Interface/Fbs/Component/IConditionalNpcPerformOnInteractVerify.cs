using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FE7 RID: 20455
	public static class IConditionalNpcPerformOnInteractVerify
	{
		// Token: 0x06020B02 RID: 133890 RVA: 0x0048B868 File Offset: 0x00489A68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionalNpcPerformOnInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionalNpcPerformOnInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionalNpcPerformOnInteractVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionalNpcPerformOnInteractVerify.<>O.<1>__Verify = new VerifyTableAction(INpcPerformOnInteractVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ABA RID: 31418
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A9 RID: 79017
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134AA RID: 79018
			public static VerifyTableAction <1>__Verify;
		}
	}
}
