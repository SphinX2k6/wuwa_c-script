using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004792 RID: 18322
	public static class IEntitiesStateVerify
	{
		// Token: 0x0601C392 RID: 115602 RVA: 0x003FEF38 File Offset: 0x003FD138
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

		// Token: 0x020079F2 RID: 31218
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339F RID: 78751
			public static VerifyTableAction <0>__Verify;
		}
	}
}
