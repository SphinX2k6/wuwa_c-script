using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B30 RID: 19248
	public static class ITeleportToPosInWorldVerify
	{
		// Token: 0x0601D09D RID: 118941 RVA: 0x00414C6C File Offset: 0x00412E6C
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

		// Token: 0x0200821B RID: 33307
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D5 RID: 82901
			public static VerifyTableAction <0>__Verify;
		}
	}
}
