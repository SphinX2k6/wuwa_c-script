using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BE RID: 21950
	public static class ICustomPrimitiveDataConfigVerify
	{
		// Token: 0x06022EBC RID: 143036 RVA: 0x004CED00 File Offset: 0x004CCF00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomPrimitiveDataConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomPrimitiveDataConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICustomPrimitiveMappingVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008329 RID: 33577
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401454C RID: 83276
			public static VerifyTableAction <0>__Verify;
		}
	}
}
