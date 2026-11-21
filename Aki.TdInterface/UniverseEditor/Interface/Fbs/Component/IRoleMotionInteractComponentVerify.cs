using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E88 RID: 24200
	public static class IRoleMotionInteractComponentVerify
	{
		// Token: 0x06028813 RID: 165907 RVA: 0x00589DA8 File Offset: 0x00587FA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRoleMotionInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleMotionInteractComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPetalGrabRoleMotionInteractVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008481 RID: 33921
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401478E RID: 83854
			public static VerifyTableAction <0>__Verify;
		}
	}
}
