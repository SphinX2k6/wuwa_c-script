using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004009 RID: 16393
	public static class ICircleRangeVerify
	{
		// Token: 0x0601672E RID: 91950 RVA: 0x00336BCC File Offset: 0x00334DCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICircleRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircleRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080DD RID: 32989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014163 RID: 82275
			public static VerifyTableAction <0>__Verify;
		}
	}
}
