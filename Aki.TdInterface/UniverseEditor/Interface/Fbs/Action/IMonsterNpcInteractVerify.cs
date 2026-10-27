using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE1 RID: 27361
	public static class IMonsterNpcInteractVerify
	{
		// Token: 0x0602FF5F RID: 196447 RVA: 0x0068596C File Offset: 0x00683B6C
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

		// Token: 0x02007DAD RID: 32173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013949 RID: 80201
			public static VerifyTableAction <0>__Verify;
		}
	}
}
