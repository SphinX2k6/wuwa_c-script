using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B6 RID: 26550
	public static class IAdjustFixedCameraOrthogonalConfigVerify
	{
		// Token: 0x0602D344 RID: 185156 RVA: 0x0062F6FC File Offset: 0x0062D8FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustFixedCameraOrthogonalConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustFixedCameraOrthogonalConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008557 RID: 34135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148D7 RID: 84183
			public static VerifyTableAction <0>__Verify;
		}
	}
}
