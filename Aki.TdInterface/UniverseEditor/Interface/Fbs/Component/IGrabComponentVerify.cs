using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052FC RID: 21244
	public static class IGrabComponentVerify
	{
		// Token: 0x06022B33 RID: 142131 RVA: 0x004CF0FC File Offset: 0x004CD2FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGrabComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGrabComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B40 RID: 31552
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013587 RID: 79239
			public static VerifyTableAction <0>__Verify;
		}
	}
}
