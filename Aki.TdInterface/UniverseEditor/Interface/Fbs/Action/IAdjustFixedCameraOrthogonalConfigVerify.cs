using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006151 RID: 24913
	public static class IAdjustFixedCameraOrthogonalConfigVerify
	{
		// Token: 0x0602AC4B RID: 175179 RVA: 0x005E5520 File Offset: 0x005E3720
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

		// Token: 0x02007CE6 RID: 31974
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013831 RID: 79921
			public static VerifyTableAction <0>__Verify;
		}
	}
}
