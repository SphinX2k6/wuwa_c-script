using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200701E RID: 28702
	public static class IInstrumentConfigVerify
	{
		// Token: 0x06031BB3 RID: 203699 RVA: 0x006BBB74 File Offset: 0x006B9D74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInstrumentConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInstrumentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IInstrumentKeyConfigsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008605 RID: 34309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149C4 RID: 84420
			public static VerifyTableAction <0>__Verify;
		}
	}
}
