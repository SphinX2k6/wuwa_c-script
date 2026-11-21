using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004814 RID: 18452
	public static class IOccupationDataVerify
	{
		// Token: 0x0601B4DE RID: 111838 RVA: 0x003DE6B0 File Offset: 0x003DC8B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfStrings(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOccupationDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOccupationDataVerify.<>O.<0>__Verify = new VerifyTableAction(IOccupationExportConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOccupationDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOccupationDataVerify.<>O.<1>__Verify = new VerifyTableAction(IAreaExportDataVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IOccupationDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IOccupationDataVerify.<>O.<2>__Verify = new VerifyTableAction(ISilentAreaExportDataVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyVectorOfStrings(tablePos, 20, false) && verifier.VerifyVectorOfStrings(tablePos, 22, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081D9 RID: 33241
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014377 RID: 82807
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014378 RID: 82808
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014379 RID: 82809
			public static VerifyTableAction <2>__Verify;
		}
	}
}
