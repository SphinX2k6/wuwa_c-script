using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415C RID: 16732
	public static class ICheckActivityStateConditionVerify
	{
		// Token: 0x0601701E RID: 94238 RVA: 0x00347F40 File Offset: 0x00346140
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckActivityStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckActivityStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080F9 RID: 33017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014189 RID: 82313
			public static VerifyTableAction <0>__Verify;
		}
	}
}
