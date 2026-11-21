using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D0 RID: 21968
	public static class ICylinderVerify
	{
		// Token: 0x06022F40 RID: 143168 RVA: 0x004CF9CC File Offset: 0x004CDBCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICylinderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICylinderVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200832A RID: 33578
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401454D RID: 83277
			public static VerifyTableAction <0>__Verify;
		}
	}
}
