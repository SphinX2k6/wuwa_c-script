using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D63 RID: 28003
	public static class IEntityLookAtPerformVerify
	{
		// Token: 0x060304F3 RID: 197875 RVA: 0x00690964 File Offset: 0x0068EB64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityLookAtPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityLookAtPerformVerify.<>O.<0>__Verify = new VerifyTableAction(ILookAtPerformOverlapMontageConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085CB RID: 34251
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401497D RID: 84349
			public static VerifyTableAction <0>__Verify;
		}
	}
}
