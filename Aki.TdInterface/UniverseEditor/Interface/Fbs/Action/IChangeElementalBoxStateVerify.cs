using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062D4 RID: 25300
	public static class IChangeElementalBoxStateVerify
	{
		// Token: 0x0602BBBE RID: 179134 RVA: 0x006048EC File Offset: 0x00602AEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeElementalBoxStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeElementalBoxStateVerify.<>O.<0>__Verify = new VerifyUnionAction(TChangeElementalBoxStateTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D0B RID: 32011
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386E RID: 79982
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
