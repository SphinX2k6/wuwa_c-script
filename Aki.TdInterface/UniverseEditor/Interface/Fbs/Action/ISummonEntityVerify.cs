using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007231 RID: 29233
	public static class ISummonEntityVerify
	{
		// Token: 0x06033DA5 RID: 212389 RVA: 0x006FA195 File Offset: 0x006F8395
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

		// Token: 0x02007E78 RID: 32376
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5C RID: 80476
			public static VerifyTableAction <0>__Verify;
		}
	}
}
