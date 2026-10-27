using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A3 RID: 30115
	public static class IVisualNovelPerformanceCgMoveVerify
	{
		// Token: 0x06036CD1 RID: 224465 RVA: 0x0077057C File Offset: 0x0076E77C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceCgMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceCgMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IVisualNovelPerformanceCgMoveVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IVisualNovelPerformanceCgMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset = 12;
						short valueVOffset = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IVisualNovelPerformanceCgMoveVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IVisualNovelPerformanceCgMoveVerify.<>O.<1>__Verify = new VerifyUnionAction(TEaseCurveTypeVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007ECD RID: 32461
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C1A RID: 80922
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C1B RID: 80923
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
