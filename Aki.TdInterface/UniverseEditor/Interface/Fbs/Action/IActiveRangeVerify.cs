using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200609A RID: 24730
	public static class IActiveRangeVerify
	{
		// Token: 0x0602A361 RID: 172897 RVA: 0x005D1D94 File Offset: 0x005CFF94
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

		// Token: 0x02007CCC RID: 31948
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137FD RID: 79869
			public static VerifyTableAction <0>__Verify;
		}
	}
}
