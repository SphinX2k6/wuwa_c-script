using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB2 RID: 24242
	public static class ISceneBulletComponentVerify
	{
		// Token: 0x060289EB RID: 166379 RVA: 0x0058DB14 File Offset: 0x0058BD14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneBulletComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneBulletComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneBulletGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008487 RID: 33927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014798 RID: 83864
			public static VerifyTableAction <0>__Verify;
		}
	}
}
