using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C9 RID: 26313
	public static class IAbsolutePos2Verify
	{
		// Token: 0x0602C341 RID: 181057 RVA: 0x00605060 File Offset: 0x00603260
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAbsolutePos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAbsolutePos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008539 RID: 34105
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401489E RID: 84126
			public static VerifyTableAction <0>__Verify;
		}
	}
}
