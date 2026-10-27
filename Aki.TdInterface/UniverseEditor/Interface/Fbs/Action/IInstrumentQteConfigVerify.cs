using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006974 RID: 26996
	public static class IInstrumentQteConfigVerify
	{
		// Token: 0x0602F24B RID: 193099 RVA: 0x0066C390 File Offset: 0x0066A590
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

		// Token: 0x02007D8C RID: 32140
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013916 RID: 80150
			public static VerifyTableAction <0>__Verify;
		}
	}
}
