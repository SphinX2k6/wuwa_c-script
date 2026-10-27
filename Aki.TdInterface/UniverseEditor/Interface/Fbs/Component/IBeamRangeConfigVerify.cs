using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F0F RID: 20239
	public static class IBeamRangeConfigVerify
	{
		// Token: 0x0601FFD3 RID: 131027 RVA: 0x00473930 File Offset: 0x00471B30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBeamRangeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBeamRangeConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A8D RID: 31373
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401346B RID: 78955
			public static VerifyTableAction <0>__Verify;
		}
	}
}
