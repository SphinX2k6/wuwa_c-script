using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D18 RID: 15640
	public static class IAtomicProcessVerify
	{
		// Token: 0x06015954 RID: 88404 RVA: 0x0031DEF4 File Offset: 0x0031C0F4
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

		// Token: 0x020078B0 RID: 30896
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013125 RID: 78117
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013126 RID: 78118
			public static VerifyTableAction <1>__Verify;
		}
	}
}
