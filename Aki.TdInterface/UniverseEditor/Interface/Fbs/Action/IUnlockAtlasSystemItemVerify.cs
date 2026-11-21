using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CBB RID: 31931
	public static class IUnlockAtlasSystemItemVerify
	{
		// Token: 0x060399A9 RID: 235945 RVA: 0x007C5D94 File Offset: 0x007C3F94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IUnlockAtlasSystemItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUnlockAtlasSystemItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TUnlockAtlasSystemOptionV2Verify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008752 RID: 34642
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD9 RID: 85209
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
