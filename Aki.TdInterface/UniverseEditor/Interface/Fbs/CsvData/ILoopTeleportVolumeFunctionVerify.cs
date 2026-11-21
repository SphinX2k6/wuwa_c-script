using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB1 RID: 19889
	public static class ILoopTeleportVolumeFunctionVerify
	{
		// Token: 0x0601EDC8 RID: 126408 RVA: 0x00450128 File Offset: 0x0044E328
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILoopTeleportVolumeFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILoopTeleportVolumeFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILoopTeleportVolumeFunctionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILoopTeleportVolumeFunctionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILoopTeleportVolumeFunctionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ILoopTeleportVolumeFunctionVerify.<>O.<2>__Verify = new VerifyTableAction(ILoopTeleportClientPlayEffectLogicVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200826A RID: 33386
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014449 RID: 83017
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401444A RID: 83018
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401444B RID: 83019
			public static VerifyTableAction <2>__Verify;
		}
	}
}
