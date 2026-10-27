using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CB RID: 21963
	public static class IMotorSlideComponentVerify
	{
		// Token: 0x0602466A RID: 149098 RVA: 0x005065C8 File Offset: 0x005047C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorSlideComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorSlideComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B9B RID: 31643
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401362F RID: 79407
			public static VerifyTableAction <0>__Verify;
		}
	}
}
