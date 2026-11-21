using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BFA RID: 19450
	public static class IEntitiesStateVerify
	{
		// Token: 0x0601DB67 RID: 121703 RVA: 0x0042B1D4 File Offset: 0x004293D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntitiesStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntitiesStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200823B RID: 33339
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014406 RID: 82950
			public static VerifyTableAction <0>__Verify;
		}
	}
}
