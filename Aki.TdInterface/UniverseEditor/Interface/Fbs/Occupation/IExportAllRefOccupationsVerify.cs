using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047FF RID: 18431
	public static class IExportAllRefOccupationsVerify
	{
		// Token: 0x0601B3B8 RID: 111544 RVA: 0x003DBC20 File Offset: 0x003D9E20
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

		// Token: 0x020081D4 RID: 33236
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014370 RID: 82800
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014371 RID: 82801
			public static VerifyTableAction <1>__Verify;
		}
	}
}
