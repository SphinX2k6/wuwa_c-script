using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EC4 RID: 24260
	public static class ISceneItemAiTypeVerify
	{
		// Token: 0x06028A7B RID: 166523 RVA: 0x0058EC18 File Offset: 0x0058CE18
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

		// Token: 0x0200848A RID: 33930
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401479C RID: 83868
			public static VerifyTableAction <0>__Verify;
		}
	}
}
