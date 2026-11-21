using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCD RID: 27853
	public static class IEnableEntityLookAtVerify
	{
		// Token: 0x06030021 RID: 196641 RVA: 0x006886CC File Offset: 0x006868CC
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

		// Token: 0x020085C2 RID: 34242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014971 RID: 84337
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014972 RID: 84338
			public static VerifyTableAction <1>__Verify;
		}
	}
}
