using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005910 RID: 22800
	public static class IShowcaseFullViewCameraConfigVerify
	{
		// Token: 0x0602688B RID: 157835 RVA: 0x0054EEB0 File Offset: 0x0054D0B0
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

		// Token: 0x02007C2B RID: 31787
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013711 RID: 79633
			public static VerifyTableAction <0>__Verify;
		}
	}
}
