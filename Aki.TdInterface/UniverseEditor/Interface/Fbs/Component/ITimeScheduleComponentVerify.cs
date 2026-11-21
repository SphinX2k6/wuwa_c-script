using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200609F RID: 24735
	public static class ITimeScheduleComponentVerify
	{
		// Token: 0x06029D83 RID: 171395 RVA: 0x005B6658 File Offset: 0x005B4858
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084D1 RID: 34001
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014817 RID: 83991
			public static VerifyTableAction <0>__Verify;
		}
	}
}
