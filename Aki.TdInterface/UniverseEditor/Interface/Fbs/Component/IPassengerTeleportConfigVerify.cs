using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BE RID: 22206
	public static class IPassengerTeleportConfigVerify
	{
		// Token: 0x0602517D RID: 151933 RVA: 0x0051F2E5 File Offset: 0x0051D4E5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPassengerTeleportConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPassengerTeleportConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BC7 RID: 31687
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401367A RID: 79482
			public static VerifyTableAction <0>__Verify;
		}
	}
}
