using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007027 RID: 28711
	public static class IInstrumentQteConfigVerify
	{
		// Token: 0x06031C1B RID: 203803 RVA: 0x006BC878 File Offset: 0x006BAA78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInstrumentQteConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInstrumentQteConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IInstrumentQteConfig_QteSequenceRowVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008607 RID: 34311
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C7 RID: 84423
			public static VerifyTableAction <0>__Verify;
		}
	}
}
