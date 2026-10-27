using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683C RID: 26684
	public static class IFocusObjectCameraConfigVerify
	{
		// Token: 0x0602E86C RID: 190572 RVA: 0x00659390 File Offset: 0x00657590
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

		// Token: 0x02007D7B RID: 32123
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013901 RID: 80129
			public static VerifyTableAction <0>__Verify;
		}
	}
}
