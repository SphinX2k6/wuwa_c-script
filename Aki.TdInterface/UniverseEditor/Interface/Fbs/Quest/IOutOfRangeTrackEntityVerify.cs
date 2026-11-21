using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043A8 RID: 17320
	public static class IOutOfRangeTrackEntityVerify
	{
		// Token: 0x060187EB RID: 100331 RVA: 0x0037D52C File Offset: 0x0037B72C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOutOfRangeTrackEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOutOfRangeTrackEntityVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008156 RID: 33110
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014246 RID: 82502
			public static VerifyTableAction <0>__Verify;
		}
	}
}
