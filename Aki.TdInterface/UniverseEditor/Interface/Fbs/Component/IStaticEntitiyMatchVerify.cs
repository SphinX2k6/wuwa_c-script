using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C4 RID: 22980
	public static class IStaticEntitiyMatchVerify
	{
		// Token: 0x06026F32 RID: 159538 RVA: 0x0055BCA4 File Offset: 0x00559EA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStaticEntitiyMatchVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStaticEntitiyMatchVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCategoryVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C3F RID: 31807
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401372F RID: 79663
			public static VerifyTableAction <0>__Verify;
		}
	}
}
