using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004645 RID: 17989
	public static class ITrackCaptureVisionsVerify
	{
		// Token: 0x0601A58F RID: 107919 RVA: 0x003BFF3C File Offset: 0x003BE13C
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

		// Token: 0x020081B6 RID: 33206
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014338 RID: 82744
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
