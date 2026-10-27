using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200439D RID: 17309
	public static class IExportAllRefOccupationsVerify
	{
		// Token: 0x06019C2A RID: 105514 RVA: 0x003B01F8 File Offset: 0x003AE3F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExportAllRefOccupationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExportAllRefOccupationsVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestAllRefOccupationsVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExportAllRefOccupationsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExportAllRefOccupationsVerify.<>O.<1>__Verify = new VerifyTableAction(ILevelPlayAllRefOccupationsVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200798B RID: 31115
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013309 RID: 78601
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401330A RID: 78602
			public static VerifyTableAction <1>__Verify;
		}
	}
}
