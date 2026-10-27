using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C5 RID: 18117
	public static class ITeleportToPosVerify
	{
		// Token: 0x0601B8AA RID: 112810 RVA: 0x003E8650 File Offset: 0x003E6850
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

		// Token: 0x020079D1 RID: 31185
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336D RID: 78701
			public static VerifyTableAction <0>__Verify;
		}
	}
}
