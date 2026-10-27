using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC9 RID: 23497
	public static class IWuWaGoMovableFloorVerify
	{
		// Token: 0x0602840C RID: 164876 RVA: 0x00587D2C File Offset: 0x00585F2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 2UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoMovableFloorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoMovableFloorVerify.<>O.<0>__Verify = new VerifyTableAction(IWuWaGoMovableGridStatePosVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C89 RID: 31881
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B4 RID: 79796
			public static VerifyTableAction <0>__Verify;
		}
	}
}
