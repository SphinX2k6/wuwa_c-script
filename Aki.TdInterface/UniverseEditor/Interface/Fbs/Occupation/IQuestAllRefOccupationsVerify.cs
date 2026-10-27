using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BE RID: 17342
	public static class IQuestAllRefOccupationsVerify
	{
		// Token: 0x06019DBD RID: 105917 RVA: 0x003B39B0 File Offset: 0x003B1BB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestAllRefOccupationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestAllRefOccupationsVerify.<>O.<0>__Verify = new VerifyTableAction(INodeRefOccupationDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestAllRefOccupationsVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IQuestAllRefOccupationsVerify.<>O.<0>__Verify = new VerifyTableAction(INodeRefOccupationDataVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestAllRefOccupationsVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IQuestAllRefOccupationsVerify.<>O.<1>__Verify = new VerifyTableAction(INodeRefOccupationsVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007991 RID: 31121
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013313 RID: 78611
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013314 RID: 78612
			public static VerifyTableAction <1>__Verify;
		}
	}
}
