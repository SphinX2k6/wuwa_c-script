using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E5 RID: 25061
	public static class IWuWaGoPressureTriggerVerify
	{
		// Token: 0x0602AA12 RID: 174610 RVA: 0x005D0124 File Offset: 0x005CE324
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

		// Token: 0x020084FC RID: 34044
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485C RID: 84060
			public static VerifyTableAction <0>__Verify;
		}
	}
}
