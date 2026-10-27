using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006875 RID: 26741
	public static class IGamepadShakeInTalkVerify
	{
		// Token: 0x0602EA2E RID: 191022 RVA: 0x0065C278 File Offset: 0x0065A478
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

		// Token: 0x02007D80 RID: 32128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013906 RID: 80134
			public static VerifyTableAction <0>__Verify;
		}
	}
}
