using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E35 RID: 24117
	public static class IPhotoTargetCaptureUiCustomPointsVerify
	{
		// Token: 0x06029499 RID: 169113 RVA: 0x005A96C0 File Offset: 0x005A78C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPhotoTargetCaptureUiCustomPointsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPhotoTargetCaptureUiCustomPointsVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CB2 RID: 31922
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E0 RID: 79840
			public static VerifyTableAction <0>__Verify;
		}
	}
}
