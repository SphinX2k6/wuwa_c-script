using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712C RID: 28972
	public static class ILiveSetParamVerify
	{
		// Token: 0x0603254B RID: 206155 RVA: 0x006CE1F8 File Offset: 0x006CC3F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILiveSetParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveSetParamVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiveParamConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200861A RID: 34330
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E4 RID: 84452
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
