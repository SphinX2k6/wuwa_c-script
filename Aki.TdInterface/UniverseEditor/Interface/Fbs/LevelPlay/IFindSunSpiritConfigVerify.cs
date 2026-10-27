using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AE RID: 17582
	public static class IFindSunSpiritConfigVerify
	{
		// Token: 0x0601A435 RID: 107573 RVA: 0x003C060C File Offset: 0x003BE80C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFindSunSpiritConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFindSunSpiritConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFindSunSpiritLevelConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079A8 RID: 31144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013332 RID: 78642
			public static VerifyTableAction <0>__Verify;
		}
	}
}
