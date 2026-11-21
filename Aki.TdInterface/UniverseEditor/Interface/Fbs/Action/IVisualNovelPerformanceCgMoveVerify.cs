using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D9C RID: 32156
	public static class IVisualNovelPerformanceCgMoveVerify
	{
		// Token: 0x0603A0FF RID: 237823 RVA: 0x007D3AFC File Offset: 0x007D1CFC
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

		// Token: 0x02008767 RID: 34663
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF4 RID: 85236
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CF5 RID: 85237
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
