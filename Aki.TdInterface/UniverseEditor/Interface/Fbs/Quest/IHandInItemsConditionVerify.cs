using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E95 RID: 16021
	public static class IHandInItemsConditionVerify
	{
		// Token: 0x060169DF RID: 92639 RVA: 0x00344784 File Offset: 0x00342984
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHandInItemsConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHandInItemsConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHandInItemsConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHandInItemsConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IHandInItemsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHandInItemsConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IHandInItemsConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IAddInteractOptionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078F4 RID: 30964
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131AF RID: 78255
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131B0 RID: 78256
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040131B1 RID: 78257
			public static VerifyTableAction <2>__Verify;
		}
	}
}
