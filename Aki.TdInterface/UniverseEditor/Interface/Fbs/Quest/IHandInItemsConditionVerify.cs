using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D0 RID: 17104
	public static class IHandInItemsConditionVerify
	{
		// Token: 0x06018016 RID: 98326 RVA: 0x0036D508 File Offset: 0x0036B708
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

		// Token: 0x0200813A RID: 33082
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401420D RID: 82445
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401420E RID: 82446
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401420F RID: 82447
			public static VerifyTableAction <2>__Verify;
		}
	}
}
