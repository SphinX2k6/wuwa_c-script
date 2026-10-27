using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B5 RID: 30133
	public static class IVisualNovelPerformanceMoveVerify
	{
		// Token: 0x06036DCD RID: 224717 RVA: 0x00772970 File Offset: 0x00770B70
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVisualNovelPerformanceMoveVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVisualNovelPerformanceMoveVerify.<>O.<1>__Verify = new VerifyUnionAction(TEaseCurveTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
					{
						short offsetId2 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IVisualNovelPerformanceMoveVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IVisualNovelPerformanceMoveVerify.<>O.<2>__Verify = new VerifyTableAction(IVisualNovelRoleConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007ED3 RID: 32467
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C23 RID: 80931
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013C24 RID: 80932
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013C25 RID: 80933
			public static VerifyTableAction <2>__Verify;
		}
	}
}
