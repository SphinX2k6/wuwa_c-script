using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E8 RID: 20968
	public static class IExploreSkillInteractComponentVerify
	{
		// Token: 0x060220C5 RID: 139461 RVA: 0x004B9D2C File Offset: 0x004B7F2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExploreSkillInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillInteractComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TExploreSkillInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 1UL, false))
				{
					short offsetId = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExploreSkillInteractComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExploreSkillInteractComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 20;
						short valueVOffset2 = 22;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IExploreSkillInteractComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IExploreSkillInteractComponentVerify.<>O.<2>__Verify = new VerifyUnionAction(TExploreSkillSearchTargetCfgVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							short offsetId2 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IExploreSkillInteractComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IExploreSkillInteractComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IIgnoresCollisionCfgVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId2, verifyAction4, false) && verifier.VerifyVectorOfStrings(tablePos, 26, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B11 RID: 31505
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013540 RID: 79168
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013541 RID: 79169
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013542 RID: 79170
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x04013543 RID: 79171
			public static VerifyTableAction <3>__Verify;
		}
	}
}
