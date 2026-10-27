using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E5 RID: 20965
	public static class IExploreSkillInteractVerify
	{
		// Token: 0x06022063 RID: 139363 RVA: 0x004B88FC File Offset: 0x004B6AFC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExploreSkillInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TExploreSkillInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false))
				{
					short offsetId = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillInteractVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillInteractVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 18;
						short valueVOffset2 = 20;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IExploreSkillInteractVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IExploreSkillInteractVerify.<>O.<2>__Verify = new VerifyUnionAction(TExploreSkillSearchTargetCfgVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							short offsetId2 = 22;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IExploreSkillInteractVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IExploreSkillInteractVerify.<>O.<3>__Verify = new VerifyTableAction(IIgnoresCollisionCfgVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId2, verifyAction4, false) && verifier.VerifyVectorOfStrings(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B10 RID: 31504
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401353C RID: 79164
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401353D RID: 79165
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401353E RID: 79166
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x0401353F RID: 79167
			public static VerifyTableAction <3>__Verify;
		}
	}
}
