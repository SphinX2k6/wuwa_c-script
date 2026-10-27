using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BB RID: 20923
	public static class IEntityStateComponentVerify
	{
		// Token: 0x06021E61 RID: 138849 RVA: 0x004B3C0C File Offset: 0x004B1E0C
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

		// Token: 0x02007B05 RID: 31493
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401352A RID: 79146
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401352B RID: 79147
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401352C RID: 79148
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401352D RID: 79149
			public static VerifyTableAction <3>__Verify;
		}
	}
}
