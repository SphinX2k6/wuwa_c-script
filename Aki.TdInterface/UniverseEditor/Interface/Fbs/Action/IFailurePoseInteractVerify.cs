using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E1A RID: 28186
	public static class IFailurePoseInteractVerify
	{
		// Token: 0x06030AB1 RID: 199345 RVA: 0x0069B300 File Offset: 0x00699500
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFailurePoseInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFailurePoseInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085E0 RID: 34272
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014997 RID: 84375
			public static VerifyTableAction <0>__Verify;
		}
	}
}
