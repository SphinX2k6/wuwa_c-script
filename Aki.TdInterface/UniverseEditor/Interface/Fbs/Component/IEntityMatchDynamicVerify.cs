using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005702 RID: 22274
	public static class IEntityMatchDynamicVerify
	{
		// Token: 0x06023C26 RID: 146470 RVA: 0x004EA5AC File Offset: 0x004E87AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityMatchDynamicVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityMatchDynamicVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008358 RID: 33624
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A0 RID: 83360
			public static VerifyTableAction <0>__Verify;
		}
	}
}
