using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006349 RID: 25417
	public static class IAreaFunctionVerify
	{
		// Token: 0x0602B1AC RID: 176556 RVA: 0x005DFF98 File Offset: 0x005DE198
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

		// Token: 0x02008504 RID: 34052
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014866 RID: 84070
			public static VerifyTableAction <0>__Verify;
		}
	}
}
