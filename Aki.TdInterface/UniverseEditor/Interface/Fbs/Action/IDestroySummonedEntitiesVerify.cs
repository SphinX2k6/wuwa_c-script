using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065A2 RID: 26018
	public static class IDestroySummonedEntitiesVerify
	{
		// Token: 0x0602D224 RID: 184868 RVA: 0x00630A71 File Offset: 0x0062EC71
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDestroySummonedEntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroySummonedEntitiesVerify.<>O.<0>__Verify = new VerifyTableAction(IDestroySummonedVehicleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D3F RID: 32063
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B4 RID: 80052
			public static VerifyTableAction <0>__Verify;
		}
	}
}
