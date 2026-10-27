using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007114 RID: 28948
	public static class ISimpleMoveVerify
	{
		// Token: 0x06033526 RID: 210214 RVA: 0x006EB1D0 File Offset: 0x006E93D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISimpleMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISimpleMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E60 RID: 32352
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A3D RID: 80445
			public static VerifyTableAction <0>__Verify;
		}
	}
}
