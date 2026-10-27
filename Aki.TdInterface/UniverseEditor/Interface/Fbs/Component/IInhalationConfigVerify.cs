using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053FD RID: 21501
	public static class IInhalationConfigVerify
	{
		// Token: 0x06023500 RID: 144640 RVA: 0x004E382C File Offset: 0x004E1A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhalationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhalationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IInhalationMatchingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IInhalationConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInhalationConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TInhalationPerformanceVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B65 RID: 31589
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C7 RID: 79303
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135C8 RID: 79304
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
