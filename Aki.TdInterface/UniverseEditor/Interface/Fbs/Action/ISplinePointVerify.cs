using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200796D RID: 31085
	public static class ISplinePointVerify
	{
		// Token: 0x06036BF1 RID: 224241 RVA: 0x00752E40 File Offset: 0x00751040
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008703 RID: 34563
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B22 RID: 84770
			public static VerifyTableAction <0>__Verify;
		}
	}
}
