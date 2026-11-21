using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616E RID: 24942
	public static class IWaySplineVerify
	{
		// Token: 0x0602A5F4 RID: 173556 RVA: 0x005C7F44 File Offset: 0x005C6144
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaySplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaySplineVerify.<>O.<0>__Verify = new VerifyTableAction(IWaySplinePointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 18, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084EB RID: 34027
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014845 RID: 84037
			public static VerifyTableAction <0>__Verify;
		}
	}
}
