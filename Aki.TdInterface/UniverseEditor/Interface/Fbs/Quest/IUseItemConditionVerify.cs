using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200469F RID: 18079
	public static class IUseItemConditionVerify
	{
		// Token: 0x0601A8D6 RID: 108758 RVA: 0x003C70EC File Offset: 0x003C52EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUseItemConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseItemConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081C2 RID: 33218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014358 RID: 82776
			public static VerifyTableAction <0>__Verify;
		}
	}
}
