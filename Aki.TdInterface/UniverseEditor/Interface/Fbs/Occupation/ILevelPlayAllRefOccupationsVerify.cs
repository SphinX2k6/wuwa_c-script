using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043A0 RID: 17312
	public static class ILevelPlayAllRefOccupationsVerify
	{
		// Token: 0x06019C50 RID: 105552 RVA: 0x003B07C8 File Offset: 0x003AE9C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayAllRefOccupationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayAllRefOccupationsVerify.<>O.<0>__Verify = new VerifyTableAction(INodeRefOccupationDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPlayAllRefOccupationsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPlayAllRefOccupationsVerify.<>O.<1>__Verify = new VerifyTableAction(INodeRefOccupationsVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200798C RID: 31116
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401330B RID: 78603
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401330C RID: 78604
			public static VerifyTableAction <1>__Verify;
		}
	}
}
