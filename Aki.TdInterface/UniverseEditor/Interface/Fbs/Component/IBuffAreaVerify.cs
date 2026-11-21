using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200545C RID: 21596
	public static class IBuffAreaVerify
	{
		// Token: 0x06021E8B RID: 138891 RVA: 0x004AC888 File Offset: 0x004AAA88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBuffAreaVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffAreaVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffAreaStateConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082EA RID: 33514
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144EA RID: 83178
			public static VerifyTableAction <0>__Verify;
		}
	}
}
