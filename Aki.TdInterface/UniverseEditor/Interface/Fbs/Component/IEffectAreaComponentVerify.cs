using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005672 RID: 22130
	public static class IEffectAreaComponentVerify
	{
		// Token: 0x06023649 RID: 144969 RVA: 0x004DE5CC File Offset: 0x004DC7CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEffectAreaComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEffectAreaComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IBuffAreaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008344 RID: 33604
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014581 RID: 83329
			public static VerifyTableAction <0>__Verify;
		}
	}
}
