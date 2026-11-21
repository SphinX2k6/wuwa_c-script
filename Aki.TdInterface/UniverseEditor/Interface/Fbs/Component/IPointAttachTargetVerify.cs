using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D57 RID: 23895
	public static class IPointAttachTargetVerify
	{
		// Token: 0x06027C78 RID: 162936 RVA: 0x0057145C File Offset: 0x0056F65C
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

		// Token: 0x02008449 RID: 33865
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401473D RID: 83773
			public static VerifyTableAction <0>__Verify;
		}
	}
}
