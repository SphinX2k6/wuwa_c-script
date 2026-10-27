using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A7 RID: 18343
	public static class IEntityDataConfigVerify
	{
		// Token: 0x0601C4CC RID: 115916 RVA: 0x00401A11 File Offset: 0x003FFC11
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityDataConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDataConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityTemplateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F7 RID: 31223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133A5 RID: 78757
			public static VerifyTableAction <0>__Verify;
		}
	}
}
