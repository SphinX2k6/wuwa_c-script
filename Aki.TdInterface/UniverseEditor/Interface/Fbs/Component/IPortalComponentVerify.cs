using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D72 RID: 23922
	public static class IPortalComponentVerify
	{
		// Token: 0x06027D38 RID: 163128 RVA: 0x00572A68 File Offset: 0x00570C68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPortalComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPortalComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TPortalConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200844D RID: 33869
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014743 RID: 83779
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
