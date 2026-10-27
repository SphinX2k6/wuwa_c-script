using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005496 RID: 21654
	public static class IItemFoundation2Verify
	{
		// Token: 0x06023A45 RID: 145989 RVA: 0x004ED978 File Offset: 0x004EBB78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemFoundation2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemFoundation2Verify.<>O.<0>__Verify = new VerifyUnionAction(TItemFoundationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B74 RID: 31604
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135E7 RID: 79335
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
