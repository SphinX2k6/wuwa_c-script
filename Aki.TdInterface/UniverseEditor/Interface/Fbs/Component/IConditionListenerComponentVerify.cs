using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF9 RID: 20473
	public static class IConditionListenerComponentVerify
	{
		// Token: 0x06020BA6 RID: 134054 RVA: 0x0048CF5C File Offset: 0x0048B15C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICondtionListenerVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AC0 RID: 31424
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134B3 RID: 79027
			public static VerifyTableAction <0>__Verify;
		}
	}
}
