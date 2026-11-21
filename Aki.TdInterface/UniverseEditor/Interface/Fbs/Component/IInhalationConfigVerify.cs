using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005983 RID: 22915
	public static class IInhalationConfigVerify
	{
		// Token: 0x060255B8 RID: 153016 RVA: 0x00520858 File Offset: 0x0051EA58
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

		// Token: 0x020083C4 RID: 33732
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401464D RID: 83533
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401464E RID: 83534
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
