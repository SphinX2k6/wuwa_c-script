using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A06 RID: 31238
	public static class ISummonEntityVerify
	{
		// Token: 0x060370A7 RID: 225447 RVA: 0x0075B4F5 File Offset: 0x007596F5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISummonEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISummonEntityVerify.<>O.<0>__Verify = new VerifyTableAction(ISummonVehicleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200870F RID: 34575
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B33 RID: 84787
			public static VerifyTableAction <0>__Verify;
		}
	}
}
