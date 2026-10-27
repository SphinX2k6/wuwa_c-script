using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AF RID: 24751
	public static class IActorFxEmoteOverrideConfigVerify
	{
		// Token: 0x0602A40D RID: 173069 RVA: 0x005D31D0 File Offset: 0x005D13D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IActorFxEmoteOverrideConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007CCF RID: 31951
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013800 RID: 79872
			public static VerifyTableAction <0>__Verify;
		}
	}
}
