using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DC9 RID: 19913
	public static class TCsvLoopTeleportDataVerify
	{
		// Token: 0x0601EE72 RID: 126578 RVA: 0x004514E0 File Offset: 0x0044F6E0
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

		// Token: 0x0200826C RID: 33388
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401444D RID: 83021
			public static VerifyTableAction <0>__Verify;
		}
	}
}
