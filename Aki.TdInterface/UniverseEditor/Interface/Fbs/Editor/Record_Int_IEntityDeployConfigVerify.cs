using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D3 RID: 18643
	public static class Record_Int_IEntityDeployConfigVerify
	{
		// Token: 0x0601D27B RID: 119419 RVA: 0x0041DA2C File Offset: 0x0041BC2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_IEntityDeployConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_IEntityDeployConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDeployConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A1A RID: 31258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133DB RID: 78811
			public static VerifyTableAction <0>__Verify;
		}
	}
}
