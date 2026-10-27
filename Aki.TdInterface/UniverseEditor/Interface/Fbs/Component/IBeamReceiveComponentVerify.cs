using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F12 RID: 20242
	public static class IBeamReceiveComponentVerify
	{
		// Token: 0x06020015 RID: 131093 RVA: 0x004743D4 File Offset: 0x004725D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeamReceiveComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeamReceiveComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBeamReceiveComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBeamReceiveComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBeamReceiveComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IBeamReceiveComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IBeamReceiveComponentVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IBeamReceiveComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007A8E RID: 31374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401346C RID: 78956
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401346D RID: 78957
			public static VerifyTableAction <1>__Verify;
		}
	}
}
