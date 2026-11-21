using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006945 RID: 26949
	public static class IChangeElementalBoxStateVerify
	{
		// Token: 0x0602E327 RID: 189223 RVA: 0x0064F8F8 File Offset: 0x0064DAF8
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

		// Token: 0x0200857E RID: 34174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014917 RID: 84247
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
