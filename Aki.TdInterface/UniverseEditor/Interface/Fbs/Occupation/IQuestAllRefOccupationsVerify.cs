using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004820 RID: 18464
	public static class IQuestAllRefOccupationsVerify
	{
		// Token: 0x0601B558 RID: 111960 RVA: 0x003DF648 File Offset: 0x003DD848
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

		// Token: 0x020081DA RID: 33242
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401437A RID: 82810
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401437B RID: 82811
			public static VerifyTableAction <1>__Verify;
		}
	}
}
