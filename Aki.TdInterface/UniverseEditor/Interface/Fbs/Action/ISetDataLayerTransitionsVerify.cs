using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A2 RID: 30626
	public static class ISetDataLayerTransitionsVerify
	{
		// Token: 0x06035C40 RID: 220224 RVA: 0x00733FC8 File Offset: 0x007321C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetDataLayerTransitionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetDataLayerTransitionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086CB RID: 34507
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC6 RID: 84678
			public static VerifyTableAction <0>__Verify;
		}
	}
}
