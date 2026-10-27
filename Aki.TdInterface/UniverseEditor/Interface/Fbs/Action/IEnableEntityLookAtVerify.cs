using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200665C RID: 26204
	public static class IEnableEntityLookAtVerify
	{
		// Token: 0x0602D850 RID: 186448 RVA: 0x0063BB64 File Offset: 0x00639D64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnableEntityLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableEntityLookAtVerify.<>O.<0>__Verify = new VerifyUnionAction(TDefaultLookAtTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEnableEntityLookAtVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEnableEntityLookAtVerify.<>O.<1>__Verify = new VerifyTableAction(ICheckFlowLookAtVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D4B RID: 32075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C5 RID: 80069
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040138C6 RID: 80070
			public static VerifyTableAction <1>__Verify;
		}
	}
}
