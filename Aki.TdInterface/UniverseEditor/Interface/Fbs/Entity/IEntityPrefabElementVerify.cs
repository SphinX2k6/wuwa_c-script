using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D1 RID: 18385
	public static class IEntityPrefabElementVerify
	{
		// Token: 0x0601C680 RID: 116352 RVA: 0x00404F85 File Offset: 0x00403185
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPrefabElementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPrefabElementVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079FD RID: 31229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133AB RID: 78763
			public static VerifyTableAction <0>__Verify;
		}
	}
}
