using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C4E RID: 19534
	public static class ILevelCustomPrimitiveDataVerify
	{
		// Token: 0x0601DF5C RID: 122716 RVA: 0x00433570 File Offset: 0x00431770
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelCustomPrimitiveDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelCustomPrimitiveDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCustomPrimitiveDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200824B RID: 33355
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014418 RID: 82968
			public static VerifyTableAction <0>__Verify;
		}
	}
}
