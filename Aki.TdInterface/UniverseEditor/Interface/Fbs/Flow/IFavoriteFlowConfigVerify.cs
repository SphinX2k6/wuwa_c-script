using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9D RID: 19357
	public static class IFavoriteFlowConfigVerify
	{
		// Token: 0x0601D855 RID: 120917 RVA: 0x004250A8 File Offset: 0x004232A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFavoriteFlowConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFavoriteFlowConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFavoriteFlowNodeInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200822A RID: 33322
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F0 RID: 82928
			public static VerifyTableAction <0>__Verify;
		}
	}
}
