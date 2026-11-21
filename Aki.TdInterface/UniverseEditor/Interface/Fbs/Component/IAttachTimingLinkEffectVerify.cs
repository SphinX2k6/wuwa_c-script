using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F3 RID: 21491
	public static class IAttachTimingLinkEffectVerify
	{
		// Token: 0x06021972 RID: 137586 RVA: 0x004A1A94 File Offset: 0x0049FC94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAttachTimingLinkEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAttachTimingLinkEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAttachTimingLinkEffectVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAttachTimingLinkEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082D8 RID: 33496
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144CA RID: 83146
			public static VerifyTableAction <0>__Verify;
		}
	}
}
