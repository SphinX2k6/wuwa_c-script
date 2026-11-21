using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA1 RID: 20129
	public static class ICheckElementalBoxStateVerify
	{
		// Token: 0x0601F32C RID: 127788 RVA: 0x004599CC File Offset: 0x00457BCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckElementalBoxStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckElementalBoxStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TElementalBoxStateTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008275 RID: 33397
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014456 RID: 83030
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
