using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006037 RID: 24631
	public static class ITargetGearGroupComponentVerify
	{
		// Token: 0x06029917 RID: 170263 RVA: 0x005AC9E8 File Offset: 0x005AABE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITargetGearGroupComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITargetGearGroupComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITargetGearGroupConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084C1 RID: 33985
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147F4 RID: 83956
			public static VerifyTableAction <0>__Verify;
		}
	}
}
