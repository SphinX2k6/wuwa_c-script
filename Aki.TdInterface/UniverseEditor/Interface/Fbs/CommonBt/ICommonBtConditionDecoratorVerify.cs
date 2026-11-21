using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064ED RID: 25837
	public static class ICommonBtConditionDecoratorVerify
	{
		// Token: 0x0602BEF3 RID: 179955 RVA: 0x005F927C File Offset: 0x005F747C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtConditionDecoratorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtConditionDecoratorVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200852D RID: 34093
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014892 RID: 84114
			public static VerifyTableAction <0>__Verify;
		}
	}
}
