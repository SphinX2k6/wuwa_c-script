using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D8 RID: 22232
	public static class IEntityCategoryWeightVerify
	{
		// Token: 0x06023A81 RID: 146049 RVA: 0x004E6FBC File Offset: 0x004E51BC
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

		// Token: 0x02008352 RID: 33618
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014596 RID: 83350
			public static VerifyTableAction <0>__Verify;
		}
	}
}
