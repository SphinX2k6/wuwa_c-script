using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041FE RID: 16894
	public static class ITrackEntitiesVerify
	{
		// Token: 0x06018EE9 RID: 102121 RVA: 0x00396540 File Offset: 0x00394740
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackEntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackEntitiesVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackEntitiesVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackEntitiesVerify.<>O.<1>__Verify = new VerifyTableAction(IOutOfRangeTrackTargetVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackEntitiesVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackEntitiesVerify.<>O.<2>__Verify = new VerifyTableAction(IOutOfRangeTrackEntityVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007970 RID: 31088
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132DE RID: 78558
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040132DF RID: 78559
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132E0 RID: 78560
			public static VerifyTableAction <2>__Verify;
		}
	}
}
