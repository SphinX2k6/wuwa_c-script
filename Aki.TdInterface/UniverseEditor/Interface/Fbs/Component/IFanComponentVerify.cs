using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005795 RID: 22421
	public static class IFanComponentVerify
	{
		// Token: 0x06024304 RID: 148228 RVA: 0x004F9CE8 File Offset: 0x004F7EE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFanComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFanComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TFanInteractOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFanComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFanComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false))
					{
						short offsetId2 = 24;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFanComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFanComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IFanEffectConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFanComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IFanComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IFanStateEffectVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008376 RID: 33654
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145CE RID: 83406
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040145CF RID: 83407
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040145D0 RID: 83408
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040145D1 RID: 83409
			public static VerifyTableAction <3>__Verify;
		}
	}
}
