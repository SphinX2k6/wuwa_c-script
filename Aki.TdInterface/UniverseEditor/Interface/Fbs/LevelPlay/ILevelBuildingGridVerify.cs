using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E4 RID: 17636
	public static class ILevelBuildingGridVerify
	{
		// Token: 0x0601A62B RID: 108075 RVA: 0x003C42DC File Offset: 0x003C24DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelBuildingGridVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelBuildingGridVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelBuildingGridVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ILevelBuildingGridVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILevelBuildingGridVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ILevelBuildingGridVerify.<>O.<1>__Verify = new VerifyTableAction(IVector2Verify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILevelBuildingGridVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ILevelBuildingGridVerify.<>O.<1>__Verify = new VerifyTableAction(IVector2Verify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020079AC RID: 31148
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013337 RID: 78647
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013338 RID: 78648
			public static VerifyTableAction <1>__Verify;
		}
	}
}
