using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005735 RID: 22325
	public static class IExhibitComponentVerify
	{
		// Token: 0x06023EBF RID: 147135 RVA: 0x004F0314 File Offset: 0x004EE514
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExhibitComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExhibitComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TExhibitConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008366 RID: 33638
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B4 RID: 83380
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
