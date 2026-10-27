using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EFF RID: 24319
	public static class ILevelRefListVerify
	{
		// Token: 0x06029C5B RID: 171099 RVA: 0x005BB55D File Offset: 0x005B975D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelRefListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelRefListVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelRefDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CC6 RID: 31942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137F6 RID: 79862
			public static VerifyTableAction <0>__Verify;
		}
	}
}
