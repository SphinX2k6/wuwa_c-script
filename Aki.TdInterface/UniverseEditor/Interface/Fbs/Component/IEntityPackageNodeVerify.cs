using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005711 RID: 22289
	public static class IEntityPackageNodeVerify
	{
		// Token: 0x06023CD2 RID: 146642 RVA: 0x004EBC9C File Offset: 0x004E9E9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPackageNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPackageNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPackageNodeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200835B RID: 33627
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145A3 RID: 83363
			public static VerifyTableAction <0>__Verify;
		}
	}
}
