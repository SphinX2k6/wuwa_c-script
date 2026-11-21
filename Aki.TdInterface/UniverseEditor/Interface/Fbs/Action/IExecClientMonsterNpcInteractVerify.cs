using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D90 RID: 28048
	public static class IExecClientMonsterNpcInteractVerify
	{
		// Token: 0x06030688 RID: 198280 RVA: 0x00693EB8 File Offset: 0x006920B8
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

		// Token: 0x020085D4 RID: 34260
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014987 RID: 84359
			public static VerifyTableAction <0>__Verify;
		}
	}
}
