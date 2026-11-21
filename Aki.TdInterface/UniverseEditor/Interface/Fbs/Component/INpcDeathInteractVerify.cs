using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBD RID: 23485
	public static class INpcDeathInteractVerify
	{
		// Token: 0x06026B84 RID: 158596 RVA: 0x0054CC28 File Offset: 0x0054AE28
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

		// Token: 0x0200840B RID: 33803
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146CF RID: 83663
			public static VerifyTableAction <0>__Verify;
		}
	}
}
