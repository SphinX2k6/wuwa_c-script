using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FC RID: 26364
	public static class IActiveRangeVerify
	{
		// Token: 0x0602CA42 RID: 182850 RVA: 0x0061BD3C File Offset: 0x00619F3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActiveRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActiveRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200853D RID: 34109
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148A3 RID: 84131
			public static VerifyTableAction <0>__Verify;
		}
	}
}
