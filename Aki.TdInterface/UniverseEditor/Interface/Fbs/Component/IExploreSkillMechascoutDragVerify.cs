using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575F RID: 22367
	public static class IExploreSkillMechascoutDragVerify
	{
		// Token: 0x060240F9 RID: 147705 RVA: 0x004F5C1C File Offset: 0x004F3E1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExploreSkillMechascoutDragVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillMechascoutDragVerify.<>O.<0>__Verify = new VerifyUnionAction(TMechascoutDragTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillMechascoutDragVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillMechascoutDragVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200836E RID: 33646
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145C5 RID: 83397
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040145C6 RID: 83398
			public static VerifyTableAction <1>__Verify;
		}
	}
}
