using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D5 RID: 21717
	public static class ILevelAiPointOffsetConfigVerify
	{
		// Token: 0x06023CA5 RID: 146597 RVA: 0x004F282C File Offset: 0x004F0A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelAiPointOffsetConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelAiPointOffsetConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B7C RID: 31612
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135F8 RID: 79352
			public static VerifyTableAction <0>__Verify;
		}
	}
}
