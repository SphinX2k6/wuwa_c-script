using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FD RID: 26877
	public static class ICameraLockTargetPositionVerify
	{
		// Token: 0x0602E063 RID: 188515 RVA: 0x0064A2F0 File Offset: 0x006484F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraLockTargetPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraLockTargetPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008574 RID: 34164
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401490B RID: 84235
			public static VerifyTableAction <0>__Verify;
		}
	}
}
