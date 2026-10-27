using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200508C RID: 20620
	public static class IDirectionalFieldVerify
	{
		// Token: 0x0602117C RID: 135548 RVA: 0x004993C4 File Offset: 0x004975C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDirectionalFieldVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDirectionalFieldVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AD4 RID: 31444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134DC RID: 79068
			public static VerifyTableAction <0>__Verify;
		}
	}
}
