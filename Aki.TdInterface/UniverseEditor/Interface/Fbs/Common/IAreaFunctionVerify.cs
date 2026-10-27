using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D15 RID: 23829
	public static class IAreaFunctionVerify
	{
		// Token: 0x06028B58 RID: 166744 RVA: 0x00597728 File Offset: 0x00595928
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAreaFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAreaFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IAirCurrentDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C93 RID: 31891
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C0 RID: 79808
			public static VerifyTableAction <0>__Verify;
		}
	}
}
