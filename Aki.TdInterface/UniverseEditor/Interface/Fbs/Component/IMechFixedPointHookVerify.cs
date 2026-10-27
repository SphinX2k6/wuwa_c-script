using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553E RID: 21822
	public static class IMechFixedPointHookVerify
	{
		// Token: 0x060240E2 RID: 147682 RVA: 0x004FB0A8 File Offset: 0x004F92A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechFixedPointHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechFixedPointHookVerify.<>O.<0>__Verify = new VerifyTableAction(IMechBehaviorConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B8C RID: 31628
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013611 RID: 79377
			public static VerifyTableAction <0>__Verify;
		}
	}
}
