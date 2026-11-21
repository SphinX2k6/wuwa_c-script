using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B5 RID: 22709
	public static class IGridObjectComponentVerify
	{
		// Token: 0x06024DC1 RID: 150977 RVA: 0x0050FDF4 File Offset: 0x0050DFF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGridObjectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGridObjectComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A9 RID: 33705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401461B RID: 83483
			public static VerifyTableAction <0>__Verify;
		}
	}
}
