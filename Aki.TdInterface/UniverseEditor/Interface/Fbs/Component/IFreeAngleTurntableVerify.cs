using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D8 RID: 21208
	public static class IFreeAngleTurntableVerify
	{
		// Token: 0x060229BE RID: 141758 RVA: 0x004CC0D8 File Offset: 0x004CA2D8
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

		// Token: 0x02007B38 RID: 31544
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401357B RID: 79227
			public static VerifyTableAction <0>__Verify;
		}
	}
}
