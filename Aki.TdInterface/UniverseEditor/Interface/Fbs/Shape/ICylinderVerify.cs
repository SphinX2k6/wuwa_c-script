using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C09 RID: 15369
	public static class ICylinderVerify
	{
		// Token: 0x060152BC RID: 86716 RVA: 0x00311324 File Offset: 0x0030F524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICylinderVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICylinderVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200789B RID: 30875
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013109 RID: 78089
			public static VerifyTableAction <0>__Verify;
		}
	}
}
