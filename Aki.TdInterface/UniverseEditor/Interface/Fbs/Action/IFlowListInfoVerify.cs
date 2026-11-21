using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9B RID: 28315
	public static class IFlowListInfoVerify
	{
		// Token: 0x06030FAB RID: 200619 RVA: 0x006A4D94 File Offset: 0x006A2F94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowListInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowListInfoVerify.<>O.<0>__Verify = new VerifyTableAction(Record_Int_IFlowTextConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowListInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowListInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IFlowInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFlowListInfoVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFlowListInfoVerify.<>O.<2>__Verify = new VerifyTableAction(IFlowSelectedNodeVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyVectorOfData(tablePos, 18, 2UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 2UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyVectorOfStrings(tablePos, 26, false) && verifier.VerifyString(tablePos, 28, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020085EE RID: 34286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149A7 RID: 84391
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149A8 RID: 84392
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040149A9 RID: 84393
			public static VerifyTableAction <2>__Verify;
		}
	}
}
