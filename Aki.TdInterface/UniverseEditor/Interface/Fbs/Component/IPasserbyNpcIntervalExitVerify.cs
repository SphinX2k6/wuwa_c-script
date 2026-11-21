using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C86 RID: 23686
	public static class IPasserbyNpcIntervalExitVerify
	{
		// Token: 0x060274AA RID: 160938 RVA: 0x005616C5 File Offset: 0x0055F8C5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcIntervalExitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcIntervalExitVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcPerNpcRandomExitIntervalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200842D RID: 33837
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401470D RID: 83725
			public static VerifyTableAction <0>__Verify;
		}
	}
}
