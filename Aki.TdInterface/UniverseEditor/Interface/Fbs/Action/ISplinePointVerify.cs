using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007198 RID: 29080
	public static class ISplinePointVerify
	{
		// Token: 0x060338F5 RID: 211189 RVA: 0x006F1BB0 File Offset: 0x006EFDB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E6C RID: 32364
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A4B RID: 80459
			public static VerifyTableAction <0>__Verify;
		}
	}
}
