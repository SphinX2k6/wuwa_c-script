using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FED RID: 20461
	public static class IConditionalStreamingSourceConfigVerify
	{
		// Token: 0x06020B34 RID: 133940 RVA: 0x0048BF20 File Offset: 0x0048A120
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

		// Token: 0x02007ABC RID: 31420
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134AC RID: 79020
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134AD RID: 79021
			public static VerifyTableAction <1>__Verify;
		}
	}
}
