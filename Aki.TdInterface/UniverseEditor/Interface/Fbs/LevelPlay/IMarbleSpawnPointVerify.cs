using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004529 RID: 17705
	public static class IMarbleSpawnPointVerify
	{
		// Token: 0x0601A9F6 RID: 109046 RVA: 0x003CCD24 File Offset: 0x003CAF24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMarbleSpawnPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMarbleSpawnPointVerify.<>O.<0>__Verify = new VerifyTableAction(ITwoDimensionTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B4 RID: 31156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401334F RID: 78671
			public static VerifyTableAction <0>__Verify;
		}
	}
}
