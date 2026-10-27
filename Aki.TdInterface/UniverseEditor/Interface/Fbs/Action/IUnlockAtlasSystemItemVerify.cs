using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C5 RID: 29893
	public static class IUnlockAtlasSystemItemVerify
	{
		// Token: 0x06036594 RID: 222612 RVA: 0x00762B44 File Offset: 0x00760D44
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

		// Token: 0x02007EB8 RID: 32440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BFF RID: 80895
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
