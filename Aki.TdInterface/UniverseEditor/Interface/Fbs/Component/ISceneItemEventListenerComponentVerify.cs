using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED0 RID: 24272
	public static class ISceneItemEventListenerComponentVerify
	{
		// Token: 0x06028AF1 RID: 166641 RVA: 0x0058FA6C File Offset: 0x0058DC6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneItemEventListenerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneItemEventListenerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneItemEventConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200848C RID: 33932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401479E RID: 83870
			public static VerifyTableAction <0>__Verify;
		}
	}
}
