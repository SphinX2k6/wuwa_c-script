using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B88 RID: 23432
	public static class IWindSourceComponentVerify
	{
		// Token: 0x060281CE RID: 164302 RVA: 0x0058371C File Offset: 0x0058191C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWindSourceComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWindSourceComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IWindDirectionalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C81 RID: 31873
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137AB RID: 79787
			public static VerifyTableAction <0>__Verify;
		}
	}
}
