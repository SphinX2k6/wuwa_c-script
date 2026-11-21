using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748E RID: 29838
	public static class IPlayerSplineMoveTargetVerify
	{
		// Token: 0x060343C7 RID: 213959 RVA: 0x0070910C File Offset: 0x0070730C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayerSplineMoveTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayerSplineMoveTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IThreeStageSplineMoveMontageVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008681 RID: 34433
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A6D RID: 84589
			public static VerifyTableAction <0>__Verify;
		}
	}
}
