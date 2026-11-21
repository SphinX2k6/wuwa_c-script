using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A0 RID: 22688
	public static class IGraph3dNodeBaseVerify
	{
		// Token: 0x06024CCB RID: 150731 RVA: 0x0050D934 File Offset: 0x0050BB34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dNodeBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dNodeBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083A3 RID: 33699
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014611 RID: 83473
			public static VerifyTableAction <0>__Verify;
		}
	}
}
