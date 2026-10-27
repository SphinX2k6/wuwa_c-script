using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E0 RID: 26336
	public static class IEntityLookAtVerify
	{
		// Token: 0x0602DC94 RID: 187540 RVA: 0x00642FD4 File Offset: 0x006411D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D53 RID: 32083
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D0 RID: 80080
			public static VerifyTableAction <0>__Verify;
		}
	}
}
