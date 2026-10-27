using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004735 RID: 18229
	public static class IFavoriteFlowConfigVerify
	{
		// Token: 0x0601C080 RID: 114816 RVA: 0x003F8E0C File Offset: 0x003F700C
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

		// Token: 0x020079E1 RID: 31201
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013389 RID: 78729
			public static VerifyTableAction <0>__Verify;
		}
	}
}
