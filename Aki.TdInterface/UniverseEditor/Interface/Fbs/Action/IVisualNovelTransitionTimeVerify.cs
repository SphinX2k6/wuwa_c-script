using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F4 RID: 30196
	public static class IVisualNovelTransitionTimeVerify
	{
		// Token: 0x06037015 RID: 225301 RVA: 0x00776994 File Offset: 0x00774B94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelTransitionTimeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelTransitionTimeVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelDateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ED8 RID: 32472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2A RID: 80938
			public static VerifyTableAction <0>__Verify;
		}
	}
}
