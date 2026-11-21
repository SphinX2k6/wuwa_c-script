using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F1 RID: 22001
	public static class IDirectionalFieldVerify
	{
		// Token: 0x060230D0 RID: 143568 RVA: 0x004D3350 File Offset: 0x004D1550
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDirectionalFieldVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDirectionalFieldVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200832E RID: 33582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401455A RID: 83290
			public static VerifyTableAction <0>__Verify;
		}
	}
}
