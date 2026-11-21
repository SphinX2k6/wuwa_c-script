using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC5 RID: 28357
	public static class IFocusObjectRotationConfigVerify
	{
		// Token: 0x0603110C RID: 200972 RVA: 0x006A75A8 File Offset: 0x006A57A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFocusObjectRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFocusObjectRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F3 RID: 34291
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149AF RID: 84399
			public static VerifyTableAction <0>__Verify;
		}
	}
}
