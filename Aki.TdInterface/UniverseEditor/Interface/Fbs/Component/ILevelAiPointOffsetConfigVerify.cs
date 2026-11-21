using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5B RID: 23131
	public static class ILevelAiPointOffsetConfigVerify
	{
		// Token: 0x06025D5D RID: 154973 RVA: 0x0052F8A0 File Offset: 0x0052DAA0
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

		// Token: 0x020083DB RID: 33755
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401467E RID: 83582
			public static VerifyTableAction <0>__Verify;
		}
	}
}
