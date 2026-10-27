using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8F RID: 28559
	public static class IServerSetPlayerPosVerify
	{
		// Token: 0x06032781 RID: 206721 RVA: 0x006CFFD5 File Offset: 0x006CE1D5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IServerSetPlayerPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IServerSetPlayerPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E2C RID: 32300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E9 RID: 80361
			public static VerifyTableAction <0>__Verify;
		}
	}
}
