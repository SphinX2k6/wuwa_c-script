using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007755 RID: 30549
	public static class IServerSetPlayerPosVerify
	{
		// Token: 0x060359D1 RID: 219601 RVA: 0x0072F98D File Offset: 0x0072DB8D
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

		// Token: 0x020086C0 RID: 34496
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB9 RID: 84665
			public static VerifyTableAction <0>__Verify;
		}
	}
}
