using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C0A RID: 27658
	public static class IDestroySummonedEntitiesVerify
	{
		// Token: 0x0602F9A8 RID: 194984 RVA: 0x0067CC35 File Offset: 0x0067AE35
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

		// Token: 0x020085B5 RID: 34229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495E RID: 84318
			public static VerifyTableAction <0>__Verify;
		}
	}
}
