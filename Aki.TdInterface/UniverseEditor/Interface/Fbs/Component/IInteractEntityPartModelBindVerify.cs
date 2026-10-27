using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544B RID: 21579
	public static class IInteractEntityPartModelBindVerify
	{
		// Token: 0x060237D8 RID: 145368 RVA: 0x004E935C File Offset: 0x004E755C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractEntityPartModelBindVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractEntityPartModelBindVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractEntityPartModelOptionPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B6C RID: 31596
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135DB RID: 79323
			public static VerifyTableAction <0>__Verify;
		}
	}
}
