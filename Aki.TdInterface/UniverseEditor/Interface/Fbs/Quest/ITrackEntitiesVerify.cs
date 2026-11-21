using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004657 RID: 18007
	public static class ITrackEntitiesVerify
	{
		// Token: 0x0601A643 RID: 108099 RVA: 0x003C1AA0 File Offset: 0x003BFCA0
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

		// Token: 0x020081B9 RID: 33209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014345 RID: 82757
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014346 RID: 82758
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014347 RID: 82759
			public static VerifyTableAction <2>__Verify;
		}
	}
}
