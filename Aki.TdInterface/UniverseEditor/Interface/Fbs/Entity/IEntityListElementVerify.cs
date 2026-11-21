using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C18 RID: 19480
	public static class IEntityListElementVerify
	{
		// Token: 0x0601DCF7 RID: 122103 RVA: 0x0042E684 File Offset: 0x0042C884
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityListElementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityListElementVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008242 RID: 33346
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401440E RID: 82958
			public static VerifyTableAction <0>__Verify;
		}
	}
}
