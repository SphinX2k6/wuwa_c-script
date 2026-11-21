using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005962 RID: 22882
	public static class IHookSpaceStationEnergyCoreVerify
	{
		// Token: 0x06025494 RID: 152724 RVA: 0x0051E574 File Offset: 0x0051C774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IHookSpaceStationEnergyCoreVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHookSpaceStationEnergyCoreVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IHookSpaceStationEnergyCoreVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020083BE RID: 33726
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014646 RID: 83526
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014647 RID: 83527
			public static VerifyTableAction <1>__Verify;
		}
	}
}
