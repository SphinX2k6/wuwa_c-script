using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A92 RID: 23186
	public static class ITimeScheduleComponentVerify
	{
		// Token: 0x0602780B RID: 161803 RVA: 0x0056F64C File Offset: 0x0056D84C
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

		// Token: 0x02007C62 RID: 31842
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013773 RID: 79731
			public static VerifyTableAction <0>__Verify;
		}
	}
}
