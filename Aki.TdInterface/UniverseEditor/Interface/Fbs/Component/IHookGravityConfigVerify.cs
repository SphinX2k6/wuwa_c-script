using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C1 RID: 21441
	public static class IHookGravityConfigVerify
	{
		// Token: 0x06023243 RID: 143939 RVA: 0x004DD440 File Offset: 0x004DB640
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHookGravityConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHookGravityConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B5C RID: 31580
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135B4 RID: 79284
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
