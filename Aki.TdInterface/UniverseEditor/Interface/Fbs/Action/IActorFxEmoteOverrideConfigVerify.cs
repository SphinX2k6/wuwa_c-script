using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006711 RID: 26385
	public static class IActorFxEmoteOverrideConfigVerify
	{
		// Token: 0x0602CAEE RID: 183022 RVA: 0x0061D178 File Offset: 0x0061B378
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

		// Token: 0x02008540 RID: 34112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A6 RID: 84134
			public static VerifyTableAction <0>__Verify;
		}
	}
}
