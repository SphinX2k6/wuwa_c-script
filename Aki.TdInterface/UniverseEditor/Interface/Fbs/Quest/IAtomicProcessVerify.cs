using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412F RID: 16687
	public static class IAtomicProcessVerify
	{
		// Token: 0x06016E8C RID: 93836 RVA: 0x0034516C File Offset: 0x0034336C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAtomicProcessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAtomicProcessVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAtomicProcessVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAtomicProcessVerify.<>O.<1>__Verify = new VerifyTableAction(IAtomicProcessStoveCoreFallVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080F4 RID: 33012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014181 RID: 82305
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014182 RID: 82306
			public static VerifyTableAction <1>__Verify;
		}
	}
}
