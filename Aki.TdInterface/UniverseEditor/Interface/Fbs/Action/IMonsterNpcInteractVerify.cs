using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007218 RID: 29208
	public static class IMonsterNpcInteractVerify
	{
		// Token: 0x06032D33 RID: 208179 RVA: 0x006DD024 File Offset: 0x006DB224
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterNpcInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterNpcInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterNpcInteractTriggerHookVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008634 RID: 34356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A07 RID: 84487
			public static VerifyTableAction <0>__Verify;
		}
	}
}
