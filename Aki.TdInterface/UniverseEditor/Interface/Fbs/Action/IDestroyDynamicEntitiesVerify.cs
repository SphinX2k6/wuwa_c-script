using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006584 RID: 25988
	public static class IDestroyDynamicEntitiesVerify
	{
		// Token: 0x0602D148 RID: 184648 RVA: 0x0062F399 File Offset: 0x0062D599
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDestroyDynamicEntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroyDynamicEntitiesVerify.<>O.<0>__Verify = new VerifyTableAction(IDestroyVisionDisplayVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D3D RID: 32061
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B2 RID: 80050
			public static VerifyTableAction <0>__Verify;
		}
	}
}
