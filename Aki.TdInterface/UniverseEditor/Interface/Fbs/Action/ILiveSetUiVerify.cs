using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007132 RID: 28978
	public static class ILiveSetUiVerify
	{
		// Token: 0x0603257B RID: 206203 RVA: 0x006CE950 File Offset: 0x006CCB50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ILiveSetUiVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveSetUiVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiveUiConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200861C RID: 34332
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E6 RID: 84454
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
