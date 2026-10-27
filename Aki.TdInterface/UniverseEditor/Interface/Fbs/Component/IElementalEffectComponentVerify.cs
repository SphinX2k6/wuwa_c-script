using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512B RID: 20779
	public static class IElementalEffectComponentVerify
	{
		// Token: 0x06021833 RID: 137267 RVA: 0x004A734C File Offset: 0x004A554C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IElementalEffectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalEffectComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TElementalMatchConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IElementalEffectComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IElementalEffectComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TElementalRangeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						short offsetId = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IElementalEffectComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IElementalEffectComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IElementalMatchActionsVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction3, false))
						{
							short offsetId2 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IElementalEffectComponentVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IElementalEffectComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IElementalMatchActionsVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AEE RID: 31470
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013509 RID: 79113
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401350A RID: 79114
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401350B RID: 79115
			public static VerifyTableAction <2>__Verify;
		}
	}
}
