using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7B RID: 28283
	public static class IRequestSystemFunctionVerify
	{
		// Token: 0x06031FD2 RID: 204754 RVA: 0x006C3211 File Offset: 0x006C1411
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRequestSystemFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRequestSystemFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IBuyGoodsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E13 RID: 32275
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CE RID: 80334
			public static VerifyTableAction <0>__Verify;
		}
	}
}
