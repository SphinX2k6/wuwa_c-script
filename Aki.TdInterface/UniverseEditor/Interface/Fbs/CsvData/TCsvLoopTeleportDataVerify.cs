using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004919 RID: 18713
	public static class TCsvLoopTeleportDataVerify
	{
		// Token: 0x0601D459 RID: 119897 RVA: 0x00421128 File Offset: 0x0041F328
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvLoopTeleportDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvLoopTeleportDataVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A1D RID: 31261
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E0 RID: 78816
			public static VerifyTableAction <0>__Verify;
		}
	}
}
