using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F8 RID: 20984
	public static class ITrafficMatchTargetVerify
	{
		// Token: 0x060210C8 RID: 135368 RVA: 0x00491300 File Offset: 0x0048F500
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrafficMatchTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrafficMatchTargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITrafficMatchTargetByEntityLogicVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082BB RID: 33467
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A2 RID: 83106
			public static VerifyTableAction <0>__Verify;
		}
	}
}
