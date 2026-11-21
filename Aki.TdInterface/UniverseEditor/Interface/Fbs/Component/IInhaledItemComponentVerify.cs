using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005995 RID: 22933
	public static class IInhaledItemComponentVerify
	{
		// Token: 0x06025642 RID: 153154 RVA: 0x00521750 File Offset: 0x0051F950
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInhaledItemComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInhaledItemComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IInhaledPerformanceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IInhaledItemComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInhaledItemComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TInhaledPerResultTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083C6 RID: 33734
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014650 RID: 83536
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014651 RID: 83537
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
