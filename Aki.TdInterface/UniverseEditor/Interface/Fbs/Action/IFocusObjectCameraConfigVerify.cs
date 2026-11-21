using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC2 RID: 28354
	public static class IFocusObjectCameraConfigVerify
	{
		// Token: 0x060310F4 RID: 200948 RVA: 0x006A72D0 File Offset: 0x006A54D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFocusObjectCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFocusObjectCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F2 RID: 34290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149AE RID: 84398
			public static VerifyTableAction <0>__Verify;
		}
	}
}
