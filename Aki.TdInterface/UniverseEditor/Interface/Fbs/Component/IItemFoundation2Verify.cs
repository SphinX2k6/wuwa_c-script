using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A1C RID: 23068
	public static class IItemFoundation2Verify
	{
		// Token: 0x06025AFD RID: 154365 RVA: 0x0052A9EC File Offset: 0x00528BEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemFoundation2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemFoundation2Verify.<>O.<0>__Verify = new VerifyUnionAction(TItemFoundationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083D3 RID: 33747
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401466D RID: 83565
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
