using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007042 RID: 28738
	public static class ISetNpcSupportedWalkingPerformVerify
	{
		// Token: 0x06032D85 RID: 208261 RVA: 0x006DBAB0 File Offset: 0x006D9CB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcSupportedWalkingPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcSupportedWalkingPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E47 RID: 32327
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A12 RID: 80402
			public static VerifyTableAction <0>__Verify;
		}
	}
}
