using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005526 RID: 21798
	public static class IMatchSequenceVerify
	{
		// Token: 0x0602402A RID: 147498 RVA: 0x004F9D40 File Offset: 0x004F7F40
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

		// Token: 0x02007B8A RID: 31626
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401360E RID: 79374
			public static VerifyTableAction <0>__Verify;
		}
	}
}
