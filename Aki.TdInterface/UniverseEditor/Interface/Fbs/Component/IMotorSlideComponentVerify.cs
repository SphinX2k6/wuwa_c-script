using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B69 RID: 23401
	public static class IMotorSlideComponentVerify
	{
		// Token: 0x06026877 RID: 157815 RVA: 0x00546B40 File Offset: 0x00544D40
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

		// Token: 0x020083FD RID: 33789
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146BE RID: 83646
			public static VerifyTableAction <0>__Verify;
		}
	}
}
