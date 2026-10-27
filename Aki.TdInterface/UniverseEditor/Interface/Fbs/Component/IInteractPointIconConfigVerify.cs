using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005469 RID: 21609
	public static class IInteractPointIconConfigVerify
	{
		// Token: 0x060238CA RID: 145610 RVA: 0x004EABF8 File Offset: 0x004E8DF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractPointIconConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractPointIconConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B6E RID: 31598
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135DD RID: 79325
			public static VerifyTableAction <0>__Verify;
		}
	}
}
