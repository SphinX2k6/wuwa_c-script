using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004802 RID: 18434
	public static class ILevelPlayAllRefOccupationsVerify
	{
		// Token: 0x0601B3DE RID: 111582 RVA: 0x003DC1F0 File Offset: 0x003DA3F0
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

		// Token: 0x020081D5 RID: 33237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014372 RID: 82802
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014373 RID: 82803
			public static VerifyTableAction <1>__Verify;
		}
	}
}
