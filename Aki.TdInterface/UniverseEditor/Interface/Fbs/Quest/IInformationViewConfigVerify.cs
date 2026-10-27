using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAD RID: 16045
	public static class IInformationViewConfigVerify
	{
		// Token: 0x06016A92 RID: 92818 RVA: 0x00345B00 File Offset: 0x00343D00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IInformationViewConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInformationViewConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TInformationViewVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F7 RID: 30967
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B4 RID: 78260
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
