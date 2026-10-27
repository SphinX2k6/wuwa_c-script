using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200663B RID: 26171
	public static class IElementalBoxTargetRelativePosVerify
	{
		// Token: 0x0602D72C RID: 186156 RVA: 0x00639AE0 File Offset: 0x00637CE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IElementalBoxTargetRelativePosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IElementalBoxTargetRelativePosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D48 RID: 32072
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C2 RID: 80066
			public static VerifyTableAction <0>__Verify;
		}
	}
}
