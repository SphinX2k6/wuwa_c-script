using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D4 RID: 18388
	public static class IEntityStateVerify
	{
		// Token: 0x0601C696 RID: 116374 RVA: 0x004051F8 File Offset: 0x004033F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079FE RID: 31230
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133AC RID: 78764
			public static VerifyTableAction <0>__Verify;
		}
	}
}
