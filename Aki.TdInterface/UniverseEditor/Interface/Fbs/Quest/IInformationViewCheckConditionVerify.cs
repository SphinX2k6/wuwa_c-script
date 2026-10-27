using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAA RID: 16042
	public static class IInformationViewCheckConditionVerify
	{
		// Token: 0x06016A7B RID: 92795 RVA: 0x0034579C File Offset: 0x0034399C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInformationViewCheckConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInformationViewCheckConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F6 RID: 30966
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B3 RID: 78259
			public static VerifyTableAction <0>__Verify;
		}
	}
}
