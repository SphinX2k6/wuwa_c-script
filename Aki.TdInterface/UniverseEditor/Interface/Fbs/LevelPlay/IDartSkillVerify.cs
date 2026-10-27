using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004481 RID: 17537
	public static class IDartSkillVerify
	{
		// Token: 0x0601A265 RID: 107109 RVA: 0x003BC3FC File Offset: 0x003BA5FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartSkillVerify.<>O.<0>__Verify = new VerifyTableAction(IDartSkillConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IDartSkillVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDartSkillVerify.<>O.<1>__Verify = new VerifyUnionAction(TDartSkillResultVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDartSkillVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDartSkillVerify.<>O.<2>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
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

		// Token: 0x020079A2 RID: 31138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013329 RID: 78633
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401332A RID: 78634
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401332B RID: 78635
			public static VerifyTableAction <2>__Verify;
		}
	}
}
