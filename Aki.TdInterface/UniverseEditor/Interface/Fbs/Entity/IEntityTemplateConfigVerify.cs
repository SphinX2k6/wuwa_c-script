using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047DA RID: 18394
	public static class IEntityTemplateConfigVerify
	{
		// Token: 0x0601C70A RID: 116490 RVA: 0x00406319 File Offset: 0x00404519
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTemplateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTemplateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityTemplateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A00 RID: 31232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133AF RID: 78767
			public static VerifyTableAction <0>__Verify;
		}
	}
}
