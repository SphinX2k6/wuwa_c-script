using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DDE RID: 15838
	public static class IDistributeParamsVerify
	{
		// Token: 0x060161F6 RID: 90614 RVA: 0x00332728 File Offset: 0x00330928
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDistributeParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDistributeParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D3 RID: 30931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013175 RID: 78197
			public static VerifyTableAction <0>__Verify;
		}
	}
}
