using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F4 RID: 24820
	public static class IActorRefWithActionContextVerify
	{
		// Token: 0x0602A671 RID: 173681 RVA: 0x005D79F8 File Offset: 0x005D5BF8
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

		// Token: 0x02007CD6 RID: 31958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013809 RID: 79881
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401380A RID: 79882
			public static VerifyTableAction <1>__Verify;
		}
	}
}
