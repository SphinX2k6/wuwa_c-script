using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004663 RID: 18019
	public static class ITrackLocationsVerify
	{
		// Token: 0x0601A6E9 RID: 108265 RVA: 0x003C35EC File Offset: 0x003C17EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackLocationsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackLocationsVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackLocationsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackLocationsVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackLocationsVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackLocationsVerify.<>O.<2>__Verify = new VerifyTableAction(IOutOfRangeTrackTargetVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITrackLocationsVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITrackLocationsVerify.<>O.<3>__Verify = new VerifyTableAction(IOutOfRangeTrackEntityVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081BC RID: 33212
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401434D RID: 82765
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401434E RID: 82766
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401434F RID: 82767
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014350 RID: 82768
			public static VerifyTableAction <3>__Verify;
		}
	}
}
