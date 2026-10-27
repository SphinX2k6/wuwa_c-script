using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E74 RID: 24180
	public static class TCsvGiantAnimDataVerify
	{
		// Token: 0x060296B7 RID: 169655 RVA: 0x005AD2C4 File Offset: 0x005AB4C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = TCsvGiantAnimDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvGiantAnimDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IGiantAnimDataType_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CB7 RID: 31927
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E5 RID: 79845
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
