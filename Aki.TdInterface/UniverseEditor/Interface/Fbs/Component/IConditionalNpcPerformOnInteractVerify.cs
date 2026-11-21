using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005546 RID: 21830
	public static class IConditionalNpcPerformOnInteractVerify
	{
		// Token: 0x06022A22 RID: 141858 RVA: 0x004C52B8 File Offset: 0x004C34B8
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

		// Token: 0x02008314 RID: 33556
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014527 RID: 83239
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014528 RID: 83240
			public static VerifyTableAction <1>__Verify;
		}
	}
}
