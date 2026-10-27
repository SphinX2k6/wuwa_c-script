using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004783 RID: 18307
	public static class IChildEntityOwnerDataVerify
	{
		// Token: 0x0601C310 RID: 115472 RVA: 0x003FE088 File Offset: 0x003FC288
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildEntityOwnerDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildEntityOwnerDataVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityOwnerEntityVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079F0 RID: 31216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401339D RID: 78749
			public static VerifyTableAction <0>__Verify;
		}
	}
}
