using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007210 RID: 29200
	public static class ISubScreenModeAdjustVerify
	{
		// Token: 0x06033CB7 RID: 212151 RVA: 0x006F886C File Offset: 0x006F6A6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenModeAdjustVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenModeAdjustVerify.<>O.<0>__Verify = new VerifyTableAction(ISetSubScreenDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E76 RID: 32374
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5A RID: 80474
			public static VerifyTableAction <0>__Verify;
		}
	}
}
