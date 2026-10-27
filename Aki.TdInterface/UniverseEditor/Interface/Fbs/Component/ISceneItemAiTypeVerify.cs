using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B7 RID: 22711
	public static class ISceneItemAiTypeVerify
	{
		// Token: 0x06026519 RID: 156953 RVA: 0x005480CC File Offset: 0x005462CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemAiTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemAiTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneItemAiTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISceneItemAiTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C1B RID: 31771
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136FA RID: 79610
			public static VerifyTableAction <0>__Verify;
		}
	}
}
