using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200516D RID: 20845
	public static class IEntityBundleComponentVerify
	{
		// Token: 0x06021A97 RID: 137879 RVA: 0x004ABC80 File Offset: 0x004A9E80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityBundleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityBundleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityBundleChildInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AF7 RID: 31479
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013517 RID: 79127
			public static VerifyTableAction <0>__Verify;
		}
	}
}
