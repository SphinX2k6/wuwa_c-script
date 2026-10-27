using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047CE RID: 18382
	public static class IEntityPrefabConfigVerify
	{
		// Token: 0x0601C66E RID: 116334 RVA: 0x00404D89 File Offset: 0x00402F89
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityPrefabConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityPrefabConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityPrefabVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079FC RID: 31228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133AA RID: 78762
			public static VerifyTableAction <0>__Verify;
		}
	}
}
