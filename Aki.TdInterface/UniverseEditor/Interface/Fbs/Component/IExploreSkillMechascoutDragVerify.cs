using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F7 RID: 20983
	public static class IExploreSkillMechascoutDragVerify
	{
		// Token: 0x06022163 RID: 139619 RVA: 0x004BB158 File Offset: 0x004B9358
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

		// Token: 0x02007B13 RID: 31507
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013545 RID: 79173
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013546 RID: 79174
			public static VerifyTableAction <1>__Verify;
		}
	}
}
