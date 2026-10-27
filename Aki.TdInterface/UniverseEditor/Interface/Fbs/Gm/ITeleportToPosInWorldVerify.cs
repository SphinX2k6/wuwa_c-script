using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C8 RID: 18120
	public static class ITeleportToPosInWorldVerify
	{
		// Token: 0x0601B8C8 RID: 112840 RVA: 0x003E89D0 File Offset: 0x003E6BD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportToPosInWorldVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportToPosInWorldVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079D2 RID: 31186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336E RID: 78702
			public static VerifyTableAction <0>__Verify;
		}
	}
}
