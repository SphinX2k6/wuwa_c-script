using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200628C RID: 25228
	public static class ICameraLockTargetPositionVerify
	{
		// Token: 0x0602B902 RID: 178434 RVA: 0x005FF4E8 File Offset: 0x005FD6E8
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

		// Token: 0x02007D01 RID: 32001
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013863 RID: 79971
			public static VerifyTableAction <0>__Verify;
		}
	}
}
