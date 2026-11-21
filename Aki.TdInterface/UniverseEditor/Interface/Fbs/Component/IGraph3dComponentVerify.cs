using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200588E RID: 22670
	public static class IGraph3dComponentVerify
	{
		// Token: 0x06024C45 RID: 150597 RVA: 0x0050CB60 File Offset: 0x0050AD60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IGraph3dNormalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A1 RID: 33697
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401460F RID: 83471
			public static VerifyTableAction <0>__Verify;
		}
	}
}
