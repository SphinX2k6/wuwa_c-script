using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EC RID: 16876
	public static class ITrackCaptureVisionsVerify
	{
		// Token: 0x06018E39 RID: 101945 RVA: 0x00394AE8 File Offset: 0x00392CE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrackCaptureVisionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackCaptureVisionsVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200796D RID: 31085
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132D2 RID: 78546
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
