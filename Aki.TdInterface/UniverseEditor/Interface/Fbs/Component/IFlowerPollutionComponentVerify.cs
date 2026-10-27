using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005281 RID: 21121
	public static class IFlowerPollutionComponentVerify
	{
		// Token: 0x06022662 RID: 140898 RVA: 0x004C4BB0 File Offset: 0x004C2DB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowerPollutionComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowerPollutionComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowerPollutionSplineConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFlowerPollutionComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFlowerPollutionComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IFlowerPollutionPointLightConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFlowerPollutionComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFlowerPollutionComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFlowerPollutionComponentVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IFlowerPollutionComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B27 RID: 31527
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013560 RID: 79200
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013561 RID: 79201
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013562 RID: 79202
			public static VerifyTableAction <2>__Verify;
		}
	}
}
