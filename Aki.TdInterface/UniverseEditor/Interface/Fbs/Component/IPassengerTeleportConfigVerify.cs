using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C62 RID: 23650
	public static class IPassengerTeleportConfigVerify
	{
		// Token: 0x060273D2 RID: 160722 RVA: 0x0056022D File Offset: 0x0055E42D
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

		// Token: 0x0200842A RID: 33834
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470A RID: 83722
			public static VerifyTableAction <0>__Verify;
		}
	}
}
