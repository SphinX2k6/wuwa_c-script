using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066E9 RID: 26345
	public static class IEntityPos2Verify
	{
		// Token: 0x0602DCF2 RID: 187634 RVA: 0x00643BD8 File Offset: 0x00641DD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPos2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPos2Verify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D56 RID: 32086
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138D4 RID: 80084
			public static VerifyTableAction <0>__Verify;
		}
	}
}
