using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B7 RID: 25783
	public static class TCsvGiantAnimDataVerify
	{
		// Token: 0x0602BD5F RID: 179551 RVA: 0x005F6268 File Offset: 0x005F4468
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

		// Token: 0x02008528 RID: 34088
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401488B RID: 84107
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
