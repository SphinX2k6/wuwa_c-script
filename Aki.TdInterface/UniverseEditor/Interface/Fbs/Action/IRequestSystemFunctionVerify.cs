using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FF RID: 30207
	public static class IRequestSystemFunctionVerify
	{
		// Token: 0x06035012 RID: 217106 RVA: 0x0071EF45 File Offset: 0x0071D145
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

		// Token: 0x0200869F RID: 34463
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A92 RID: 84626
			public static VerifyTableAction <0>__Verify;
		}
	}
}
