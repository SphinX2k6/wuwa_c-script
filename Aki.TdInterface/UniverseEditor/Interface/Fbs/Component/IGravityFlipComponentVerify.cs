using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A9 RID: 22697
	public static class IGravityFlipComponentVerify
	{
		// Token: 0x06024D2B RID: 150827 RVA: 0x0050E644 File Offset: 0x0050C844
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGravityFlipComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityFlipComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IGravityFlipConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A6 RID: 33702
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014615 RID: 83477
			public static VerifyTableAction <0>__Verify;
		}
	}
}
