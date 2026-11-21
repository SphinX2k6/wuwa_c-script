using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007802 RID: 30722
	public static class ISetNpcHandInHandPerformVerify
	{
		// Token: 0x06035F98 RID: 221080 RVA: 0x0073AD34 File Offset: 0x00738F34
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

		// Token: 0x020086D9 RID: 34521
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE0 RID: 84704
			public static VerifyTableAction <0>__Verify;
		}
	}
}
