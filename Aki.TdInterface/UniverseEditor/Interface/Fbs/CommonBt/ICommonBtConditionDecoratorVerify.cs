using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAA RID: 24234
	public static class ICommonBtConditionDecoratorVerify
	{
		// Token: 0x0602984B RID: 170059 RVA: 0x005B02D8 File Offset: 0x005AE4D8
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

		// Token: 0x02007CBC RID: 31932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137EC RID: 79852
			public static VerifyTableAction <0>__Verify;
		}
	}
}
