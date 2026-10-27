using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006869 RID: 26729
	public static class IFunctionVerify
	{
		// Token: 0x0602E9DA RID: 190938 RVA: 0x0065BA3C File Offset: 0x00659C3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFunctionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D7F RID: 32127
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013905 RID: 80133
			public static VerifyTableAction <0>__Verify;
		}
	}
}
