using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007039 RID: 28729
	public static class ISetNpcHandInHandPerformVerify
	{
		// Token: 0x06032D2F RID: 208175 RVA: 0x006DB058 File Offset: 0x006D9258
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcHandInHandPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcHandInHandPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInHandInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E44 RID: 32324
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A0F RID: 80399
			public static VerifyTableAction <0>__Verify;
		}
	}
}
