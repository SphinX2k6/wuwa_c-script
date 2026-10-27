using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B31 RID: 15153
	public static class IWoodenBoxProliferatePositionListVerify
	{
		// Token: 0x06014B58 RID: 84824 RVA: 0x0030313C File Offset: 0x0030133C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWoodenBoxProliferatePositionListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWoodenBoxProliferatePositionListVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007886 RID: 30854
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130EF RID: 78063
			public static VerifyTableAction <0>__Verify;
		}
	}
}
