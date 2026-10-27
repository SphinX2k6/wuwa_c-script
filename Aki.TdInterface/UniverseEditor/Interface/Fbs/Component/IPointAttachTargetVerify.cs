using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005750 RID: 22352
	public static class IPointAttachTargetVerify
	{
		// Token: 0x06025758 RID: 153432 RVA: 0x0052B2D0 File Offset: 0x005294D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPointAttachTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPointAttachTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BDB RID: 31707
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401369D RID: 79517
			public static VerifyTableAction <0>__Verify;
		}
	}
}
