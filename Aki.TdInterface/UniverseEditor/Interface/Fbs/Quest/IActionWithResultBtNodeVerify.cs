using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF1 RID: 15601
	public static class IActionWithResultBtNodeVerify
	{
		// Token: 0x060157C4 RID: 88004 RVA: 0x0031A8C4 File Offset: 0x00318AC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActionWithResultBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActionWithResultBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActionWithResultBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActionWithResultBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078AA RID: 30890
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401311B RID: 78107
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401311C RID: 78108
			public static VerifyTableAction <1>__Verify;
		}
	}
}
