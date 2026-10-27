using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200505C RID: 20572
	public static class ICustomPrimitiveDataConfigVerify
	{
		// Token: 0x06020F82 RID: 135042 RVA: 0x0049504C File Offset: 0x0049324C
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

		// Token: 0x02007ACF RID: 31439
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134CE RID: 79054
			public static VerifyTableAction <0>__Verify;
		}
	}
}
