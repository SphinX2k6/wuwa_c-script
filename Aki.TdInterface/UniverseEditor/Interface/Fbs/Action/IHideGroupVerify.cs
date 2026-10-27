using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E7 RID: 26855
	public static class IHideGroupVerify
	{
		// Token: 0x0602ED9C RID: 191900 RVA: 0x006645AC File Offset: 0x006627AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHideGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHideGroupVerify.<>O.<0>__Verify = new VerifyUnionAction(THideGroupConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D87 RID: 32135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401390E RID: 80142
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
