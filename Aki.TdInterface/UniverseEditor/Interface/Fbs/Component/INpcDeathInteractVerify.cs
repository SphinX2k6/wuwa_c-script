using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561F RID: 22047
	public static class INpcDeathInteractVerify
	{
		// Token: 0x06024974 RID: 149876 RVA: 0x0050C610 File Offset: 0x0050A810
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcDeathInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcDeathInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA9 RID: 31657
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013640 RID: 79424
			public static VerifyTableAction <0>__Verify;
		}
	}
}
