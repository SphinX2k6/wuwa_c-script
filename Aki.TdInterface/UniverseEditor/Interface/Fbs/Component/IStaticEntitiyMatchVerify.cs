using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD1 RID: 24529
	public static class IStaticEntitiyMatchVerify
	{
		// Token: 0x060294A6 RID: 169126 RVA: 0x005A2B5C File Offset: 0x005A0D5C
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

		// Token: 0x020084AE RID: 33966
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147D2 RID: 83922
			public static VerifyTableAction <0>__Verify;
		}
	}
}
