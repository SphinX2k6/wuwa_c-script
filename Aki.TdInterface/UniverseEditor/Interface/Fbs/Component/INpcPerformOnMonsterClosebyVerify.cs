using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563A RID: 22074
	public static class INpcPerformOnMonsterClosebyVerify
	{
		// Token: 0x06024B04 RID: 150276 RVA: 0x005105BC File Offset: 0x0050E7BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcPerformOnMonsterClosebyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcPerformOnMonsterClosebyVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcPerformOnMonsterClosebyVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcPerformOnMonsterClosebyVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BAE RID: 31662
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013650 RID: 79440
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013651 RID: 79441
			public static VerifyTableAction <1>__Verify;
		}
	}
}
