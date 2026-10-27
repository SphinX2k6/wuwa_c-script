using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCF RID: 23503
	public static class IWuWaGoPressureTriggerVerify
	{
		// Token: 0x0602844E RID: 164942 RVA: 0x00588694 File Offset: 0x00586894
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoPressureTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoPressureTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWuWaGoPressureTriggerVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWuWaGoPressureTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C8B RID: 31883
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B6 RID: 79798
			public static VerifyTableAction <0>__Verify;
		}
	}
}
