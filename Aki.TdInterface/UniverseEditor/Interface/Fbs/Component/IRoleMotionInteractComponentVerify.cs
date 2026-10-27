using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587B RID: 22651
	public static class IRoleMotionInteractComponentVerify
	{
		// Token: 0x060262B1 RID: 156337 RVA: 0x0054325C File Offset: 0x0054145C
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

		// Token: 0x02007C12 RID: 31762
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136EC RID: 79596
			public static VerifyTableAction <0>__Verify;
		}
	}
}
