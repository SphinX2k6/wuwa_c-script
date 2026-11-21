using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BA RID: 22202
	public static class IEntityAttachTargetVerify
	{
		// Token: 0x06023919 RID: 145689 RVA: 0x004E4174 File Offset: 0x004E2374
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityAttachTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityAttachTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200834D RID: 33613
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014590 RID: 83344
			public static VerifyTableAction <0>__Verify;
		}
	}
}
