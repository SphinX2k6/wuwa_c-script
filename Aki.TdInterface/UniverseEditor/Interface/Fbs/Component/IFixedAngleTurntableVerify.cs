using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D1 RID: 22481
	public static class IFixedAngleTurntableVerify
	{
		// Token: 0x060244C4 RID: 148676 RVA: 0x004FCC28 File Offset: 0x004FAE28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedAngleTurntableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedAngleTurntableVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedAngleItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200837C RID: 33660
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145D8 RID: 83416
			public static VerifyTableAction <0>__Verify;
		}
	}
}
