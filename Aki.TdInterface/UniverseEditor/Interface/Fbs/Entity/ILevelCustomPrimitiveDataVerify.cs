using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E6 RID: 18406
	public static class ILevelCustomPrimitiveDataVerify
	{
		// Token: 0x0601C75F RID: 116575 RVA: 0x00406C20 File Offset: 0x00404E20
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

		// Token: 0x02007A02 RID: 31234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B1 RID: 78769
			public static VerifyTableAction <0>__Verify;
		}
	}
}
