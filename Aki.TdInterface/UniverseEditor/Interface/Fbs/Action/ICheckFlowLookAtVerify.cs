using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CE RID: 27086
	public static class ICheckFlowLookAtVerify
	{
		// Token: 0x0602E782 RID: 190338 RVA: 0x006571D4 File Offset: 0x006553D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckFlowLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFlowLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckFlowLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200858A RID: 34186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014925 RID: 84261
			public static VerifyTableAction <0>__Verify;
		}
	}
}
