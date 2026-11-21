using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554C RID: 21836
	public static class IConditionalStreamingSourceConfigVerify
	{
		// Token: 0x06022A54 RID: 141908 RVA: 0x004C5970 File Offset: 0x004C3B70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionalStreamingSourceConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionalStreamingSourceConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IConditionalStreamingSourceConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionalStreamingSourceConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IStreamingSourceConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008316 RID: 33558
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401452A RID: 83242
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401452B RID: 83243
			public static VerifyTableAction <1>__Verify;
		}
	}
}
