using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F2 RID: 22514
	public static class IRandomPoolChooseVerify
	{
		// Token: 0x06025D6B RID: 154987 RVA: 0x00537EDC File Offset: 0x005360DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRandomPoolChooseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomPoolChooseVerify.<>O.<0>__Verify = new VerifyTableAction(IRandomPoolConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BFC RID: 31740
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136CA RID: 79562
			public static VerifyTableAction <0>__Verify;
		}
	}
}
