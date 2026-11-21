using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A5 RID: 30629
	public static class ISetElementalBoxToTargetVerify
	{
		// Token: 0x06035C5D RID: 220253 RVA: 0x00734464 File Offset: 0x00732664
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetElementalBoxToTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetElementalBoxToTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086CC RID: 34508
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC7 RID: 84679
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
