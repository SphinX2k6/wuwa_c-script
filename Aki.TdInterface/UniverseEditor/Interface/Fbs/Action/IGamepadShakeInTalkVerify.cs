using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F16 RID: 28438
	public static class IGamepadShakeInTalkVerify
	{
		// Token: 0x06031368 RID: 201576 RVA: 0x006AB2F8 File Offset: 0x006A94F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGamepadShakeInTalkVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGamepadShakeInTalkVerify.<>O.<0>__Verify = new VerifyTableAction(IGamepadShakeOptionsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F9 RID: 34297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B5 RID: 84405
			public static VerifyTableAction <0>__Verify;
		}
	}
}
