using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E9 RID: 21993
	public static class INavMeshComponentVerify
	{
		// Token: 0x060247D2 RID: 149458 RVA: 0x00509660 File Offset: 0x00507860
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

		// Token: 0x02007BA1 RID: 31649
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013637 RID: 79415
			public static VerifyTableAction <0>__Verify;
		}
	}
}
