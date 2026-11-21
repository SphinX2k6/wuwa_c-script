using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006472 RID: 25714
	public static class IPhotoTargetCaptureUiCustomPointsVerify
	{
		// Token: 0x0602BB23 RID: 178979 RVA: 0x005F23F0 File Offset: 0x005F05F0
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

		// Token: 0x02008523 RID: 34083
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014886 RID: 84102
			public static VerifyTableAction <0>__Verify;
		}
	}
}
