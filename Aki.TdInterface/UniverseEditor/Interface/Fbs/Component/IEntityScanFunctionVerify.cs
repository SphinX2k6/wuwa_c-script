using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005714 RID: 22292
	public static class IEntityScanFunctionVerify
	{
		// Token: 0x06023CF4 RID: 146676 RVA: 0x004EC0B0 File Offset: 0x004EA2B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityScanFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityScanFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IScanTraceEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200835C RID: 33628
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A4 RID: 83364
			public static VerifyTableAction <0>__Verify;
		}
	}
}
