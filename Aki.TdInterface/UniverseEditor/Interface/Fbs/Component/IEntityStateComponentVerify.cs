using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005720 RID: 22304
	public static class IEntityStateComponentVerify
	{
		// Token: 0x06023DB9 RID: 146873 RVA: 0x004EDC74 File Offset: 0x004EBE74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityStateComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityStateComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityStateComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IStateChangeBehaviorVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEntityStateComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEntityStateComponentVerify.<>O.<2>__Verify = new VerifyTableAction(ILockConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IEntityStateComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IEntityStateComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IStateConfigVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyVectorOfStrings(tablePos, 20, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200835F RID: 33631
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A8 RID: 83368
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145A9 RID: 83369
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040145AA RID: 83370
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040145AB RID: 83371
			public static VerifyTableAction <3>__Verify;
		}
	}
}
