using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF6 RID: 23542
	public static class TComponentDataVerify
	{
		// Token: 0x0602863C RID: 165436 RVA: 0x0058F65C File Offset: 0x0058D85C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = TComponentDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TComponentDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IComponentBase_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C8E RID: 31886
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B9 RID: 79801
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
