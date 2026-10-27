using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696B RID: 26987
	public static class IInstrumentConfigVerify
	{
		// Token: 0x0602F1E3 RID: 192995 RVA: 0x0066B68C File Offset: 0x0066988C
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

		// Token: 0x02007D8A RID: 32138
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013913 RID: 80147
			public static VerifyTableAction <0>__Verify;
		}
	}
}
