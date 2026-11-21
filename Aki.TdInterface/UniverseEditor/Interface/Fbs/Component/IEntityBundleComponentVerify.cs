using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D2 RID: 22226
	public static class IEntityBundleComponentVerify
	{
		// Token: 0x060239EB RID: 145899 RVA: 0x004E5C0C File Offset: 0x004E3E0C
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

		// Token: 0x02008351 RID: 33617
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014595 RID: 83349
			public static VerifyTableAction <0>__Verify;
		}
	}
}
