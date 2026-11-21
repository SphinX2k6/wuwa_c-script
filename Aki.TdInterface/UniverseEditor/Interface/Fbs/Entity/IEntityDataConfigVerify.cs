using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0F RID: 19471
	public static class IEntityDataConfigVerify
	{
		// Token: 0x0601DCA1 RID: 122017 RVA: 0x0042DCAD File Offset: 0x0042BEAD
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

		// Token: 0x02008240 RID: 33344
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401440C RID: 82956
			public static VerifyTableAction <0>__Verify;
		}
	}
}
