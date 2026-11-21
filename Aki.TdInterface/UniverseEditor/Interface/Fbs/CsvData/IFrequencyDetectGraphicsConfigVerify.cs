using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D84 RID: 19844
	public static class IFrequencyDetectGraphicsConfigVerify
	{
		// Token: 0x0601EC40 RID: 126016 RVA: 0x0044D530 File Offset: 0x0044B730
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFrequencyDetectGraphicsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyDetectGraphicsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFrequencyDetectGraphicsConfig_CanvasVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFrequencyDetectGraphicsConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFrequencyDetectGraphicsConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IFrequencyDetectGraphicsLineVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008266 RID: 33382
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014444 RID: 83012
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014445 RID: 83013
			public static VerifyTableAction <1>__Verify;
		}
	}
}
