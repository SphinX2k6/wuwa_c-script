using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044BA RID: 17594
	public static class IFindSunSpiritGridConfigVerify
	{
		// Token: 0x0601A493 RID: 107667 RVA: 0x003C1224 File Offset: 0x003BF424
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFindSunSpiritGridConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFindSunSpiritGridConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079A9 RID: 31145
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013333 RID: 78643
			public static VerifyTableAction <0>__Verify;
		}
	}
}
