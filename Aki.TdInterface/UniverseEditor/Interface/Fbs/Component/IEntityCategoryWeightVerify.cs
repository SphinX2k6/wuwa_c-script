using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005173 RID: 20851
	public static class IEntityCategoryWeightVerify
	{
		// Token: 0x06021B29 RID: 138025 RVA: 0x004ACF9C File Offset: 0x004AB19C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityCategoryWeightVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityCategoryWeightVerify.<>O.<0>__Verify = new VerifyTableAction(IStaticEntitiyMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AF8 RID: 31480
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013518 RID: 79128
			public static VerifyTableAction <0>__Verify;
		}
	}
}
