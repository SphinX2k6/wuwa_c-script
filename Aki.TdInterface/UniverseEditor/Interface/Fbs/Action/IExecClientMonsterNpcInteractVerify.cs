using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006710 RID: 26384
	public static class IExecClientMonsterNpcInteractVerify
	{
		// Token: 0x0602DE42 RID: 187970 RVA: 0x00646774 File Offset: 0x00644974
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExecClientMonsterNpcInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecClientMonsterNpcInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterNpcInteractTriggerHookVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D5D RID: 32093
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138DB RID: 80091
			public static VerifyTableAction <0>__Verify;
		}
	}
}
