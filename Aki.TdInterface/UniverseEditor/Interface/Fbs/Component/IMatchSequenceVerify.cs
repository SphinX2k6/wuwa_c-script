using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAC RID: 23212
	public static class IMatchSequenceVerify
	{
		// Token: 0x060260E4 RID: 155876 RVA: 0x00536E64 File Offset: 0x00535064
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMatchSequenceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMatchSequenceVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083E9 RID: 33769
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014694 RID: 83604
			public static VerifyTableAction <0>__Verify;
		}
	}
}
