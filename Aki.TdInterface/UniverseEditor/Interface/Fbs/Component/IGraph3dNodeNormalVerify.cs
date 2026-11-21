using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A3 RID: 22691
	public static class IGraph3dNodeNormalVerify
	{
		// Token: 0x06024CE1 RID: 150753 RVA: 0x0050DBC0 File Offset: 0x0050BDC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dNodeNormalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dNodeNormalVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A4 RID: 33700
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014612 RID: 83474
			public static VerifyTableAction <0>__Verify;
		}
	}
}
