using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004922 RID: 18722
	public static class IFindSunSpiritGridConfigVerify
	{
		// Token: 0x0601BC64 RID: 113764 RVA: 0x003ED430 File Offset: 0x003EB630
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

		// Token: 0x020081F2 RID: 33266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401439A RID: 82842
			public static VerifyTableAction <0>__Verify;
		}
	}
}
