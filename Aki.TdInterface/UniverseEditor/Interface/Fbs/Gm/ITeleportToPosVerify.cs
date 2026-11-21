using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B2D RID: 19245
	public static class ITeleportToPosVerify
	{
		// Token: 0x0601D07F RID: 118911 RVA: 0x004148EC File Offset: 0x00412AEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportToPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportToPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200821A RID: 33306
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D4 RID: 82900
			public static VerifyTableAction <0>__Verify;
		}
	}
}
