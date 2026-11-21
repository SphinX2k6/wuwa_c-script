using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005843 RID: 22595
	public static class IFreeAngleTurntableVerify
	{
		// Token: 0x06024982 RID: 149890 RVA: 0x005071D4 File Offset: 0x005053D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFreeAngleTurntableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFreeAngleTurntableVerify.<>O.<0>__Verify = new VerifyTableAction(IFreeAngleItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008394 RID: 33684
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145FC RID: 83452
			public static VerifyTableAction <0>__Verify;
		}
	}
}
