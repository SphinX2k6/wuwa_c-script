using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004916 RID: 18710
	public static class IFindSunSpiritConfigVerify
	{
		// Token: 0x0601BC06 RID: 113670 RVA: 0x003EC818 File Offset: 0x003EAA18
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

		// Token: 0x020081F1 RID: 33265
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014399 RID: 82841
			public static VerifyTableAction <0>__Verify;
		}
	}
}
