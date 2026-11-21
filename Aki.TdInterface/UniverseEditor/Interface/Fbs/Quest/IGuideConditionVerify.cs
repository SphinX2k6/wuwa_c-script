using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C1 RID: 17089
	public static class IGuideConditionVerify
	{
		// Token: 0x06017F46 RID: 98118 RVA: 0x0036B8C8 File Offset: 0x00369AC8
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

		// Token: 0x02008137 RID: 33079
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014209 RID: 82441
			public static VerifyTableAction <0>__Verify;
		}
	}
}
