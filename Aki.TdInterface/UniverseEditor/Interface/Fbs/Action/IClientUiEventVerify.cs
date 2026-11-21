using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8B RID: 27275
	public static class IClientUiEventVerify
	{
		// Token: 0x0602ECE4 RID: 191716 RVA: 0x00661160 File Offset: 0x0065F360
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientUiEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientUiEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientEventUiVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200859C RID: 34204
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014940 RID: 84288
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
