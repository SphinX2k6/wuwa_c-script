using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006756 RID: 26454
	public static class IActorRefWithActionContextVerify
	{
		// Token: 0x0602CD52 RID: 183634 RVA: 0x006219A0 File Offset: 0x0061FBA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorRefWithActionContextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorRefWithActionContextVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActorRefWithActionContextVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActorRefWithActionContextVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008547 RID: 34119
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148AF RID: 84143
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040148B0 RID: 84144
			public static VerifyTableAction <1>__Verify;
		}
	}
}
