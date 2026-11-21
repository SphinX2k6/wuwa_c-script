using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487F RID: 18559
	public static class ISubWpDataVerify
	{
		// Token: 0x0601B730 RID: 112432 RVA: 0x003E28DC File Offset: 0x003E0ADC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubWpDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubWpDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081E0 RID: 33248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014381 RID: 82817
			public static VerifyTableAction <0>__Verify;
		}
	}
}
