using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E86 RID: 16006
	public static class IGuideConditionVerify
	{
		// Token: 0x0601690F RID: 92431 RVA: 0x00342B44 File Offset: 0x00340D44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGuideConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGuideConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F1 RID: 30961
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131AB RID: 78251
			public static VerifyTableAction <0>__Verify;
		}
	}
}
