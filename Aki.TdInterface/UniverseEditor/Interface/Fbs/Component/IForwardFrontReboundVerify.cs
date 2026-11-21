using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005828 RID: 22568
	public static class IForwardFrontReboundVerify
	{
		// Token: 0x06024854 RID: 149588 RVA: 0x00504590 File Offset: 0x00502790
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IForwardFrontReboundVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IForwardFrontReboundVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200838D RID: 33677
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F0 RID: 83440
			public static VerifyTableAction <0>__Verify;
		}
	}
}
