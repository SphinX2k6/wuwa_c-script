using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005789 RID: 22409
	public static class IProceduralMaterialComponentVerify
	{
		// Token: 0x06025926 RID: 153894 RVA: 0x0052EBE8 File Offset: 0x0052CDE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProceduralMaterialComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProceduralMaterialComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICustomPrimitiveDataConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BE6 RID: 31718
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136AB RID: 79531
			public static VerifyTableAction <0>__Verify;
		}
	}
}
