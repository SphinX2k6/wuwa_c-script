using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200625F RID: 25183
	public static class IBvbSendAiEventVerify
	{
		// Token: 0x0602B727 RID: 177959 RVA: 0x005FB18C File Offset: 0x005F938C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbSendAiEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbSendAiEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TBvbEventDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CFB RID: 31995
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401385A RID: 79962
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
