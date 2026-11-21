using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E32 RID: 28210
	public static class IFireBulletVerify
	{
		// Token: 0x06030B62 RID: 199522 RVA: 0x0069C690 File Offset: 0x0069A890
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

		// Token: 0x020085E2 RID: 34274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401499A RID: 84378
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
