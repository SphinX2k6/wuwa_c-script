using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004931 RID: 18737
	public static class IFindSunSpiritLevelConfigVerify
	{
		// Token: 0x0601BCE6 RID: 113894 RVA: 0x003EE16C File Offset: 0x003EC36C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFindSunSpiritLevelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFindSunSpiritLevelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFindSunSpiritGridConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081F3 RID: 33267
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401439B RID: 82843
			public static VerifyTableAction <0>__Verify;
		}
	}
}
