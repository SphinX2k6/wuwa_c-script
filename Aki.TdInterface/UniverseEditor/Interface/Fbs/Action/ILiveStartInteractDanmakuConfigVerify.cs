using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007135 RID: 28981
	public static class ILiveStartInteractDanmakuConfigVerify
	{
		// Token: 0x06032597 RID: 206231 RVA: 0x006CED00 File Offset: 0x006CCF00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiveStartInteractDanmakuConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveStartInteractDanmakuConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILiveInteractDanmakuListenerGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200861D RID: 34333
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E7 RID: 84455
			public static VerifyTableAction <0>__Verify;
		}
	}
}
