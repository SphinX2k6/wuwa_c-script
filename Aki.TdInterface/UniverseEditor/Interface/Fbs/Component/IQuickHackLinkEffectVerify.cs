using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CE RID: 22478
	public static class IQuickHackLinkEffectVerify
	{
		// Token: 0x06025BD1 RID: 154577 RVA: 0x005344F4 File Offset: 0x005326F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuickHackLinkEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuickHackLinkEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuickHackLinkEffectVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IQuickHackLinkEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BF1 RID: 31729
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136BC RID: 79548
			public static VerifyTableAction <0>__Verify;
		}
	}
}
