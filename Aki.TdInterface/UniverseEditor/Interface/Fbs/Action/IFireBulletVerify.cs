using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B2 RID: 26546
	public static class IFireBulletVerify
	{
		// Token: 0x0602E31C RID: 189212 RVA: 0x0064EF4C File Offset: 0x0064D14C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFireBulletVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFireBulletVerify.<>O.<0>__Verify = new VerifyUnionAction(TFireBulletVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D6B RID: 32107
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138EE RID: 80110
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
