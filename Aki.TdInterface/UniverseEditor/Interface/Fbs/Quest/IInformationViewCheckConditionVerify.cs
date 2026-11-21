using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E8 RID: 17128
	public static class IInformationViewCheckConditionVerify
	{
		// Token: 0x060180C8 RID: 98504 RVA: 0x0036E724 File Offset: 0x0036C924
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

		// Token: 0x0200813C RID: 33084
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014211 RID: 82449
			public static VerifyTableAction <0>__Verify;
		}
	}
}
