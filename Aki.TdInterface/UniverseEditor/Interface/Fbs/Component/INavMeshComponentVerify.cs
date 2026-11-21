using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B87 RID: 23431
	public static class INavMeshComponentVerify
	{
		// Token: 0x060269DF RID: 158175 RVA: 0x00549BD8 File Offset: 0x00547DD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INavMeshComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INavMeshComponentVerify.<>O.<0>__Verify = new VerifyTableAction(INavMeshAkiEntitySourceVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008403 RID: 33795
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C6 RID: 83654
			public static VerifyTableAction <0>__Verify;
		}
	}
}
