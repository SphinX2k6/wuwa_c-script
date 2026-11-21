using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C06 RID: 19462
	public static class IEntityCustomPrimitiveDataVerify
	{
		// Token: 0x0601DBFD RID: 121853 RVA: 0x0042C5B8 File Offset: 0x0042A7B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityCustomPrimitiveDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityCustomPrimitiveDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityCustomPrimitiveData_CustomDataRowVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200823E RID: 33342
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014409 RID: 82953
			public static VerifyTableAction <0>__Verify;
		}
	}
}
