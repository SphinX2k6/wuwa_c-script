using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007099 RID: 28825
	public static class ISetTimeScaleVerify
	{
		// Token: 0x060330AD RID: 209069 RVA: 0x006E279D File Offset: 0x006E099D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetTimeScaleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetTimeScaleVerify.<>O.<0>__Verify = new VerifyTableAction(ISetGlobalTimeScaleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E56 RID: 32342
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A2D RID: 80429
			public static VerifyTableAction <0>__Verify;
		}
	}
}
