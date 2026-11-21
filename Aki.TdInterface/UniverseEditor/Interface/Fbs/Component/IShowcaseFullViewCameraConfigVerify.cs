using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F1D RID: 24349
	public static class IShowcaseFullViewCameraConfigVerify
	{
		// Token: 0x06028DF5 RID: 167413 RVA: 0x00595B1C File Offset: 0x00593D1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowcaseFullViewCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowcaseFullViewCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200849A RID: 33946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B3 RID: 83891
			public static VerifyTableAction <0>__Verify;
		}
	}
}
