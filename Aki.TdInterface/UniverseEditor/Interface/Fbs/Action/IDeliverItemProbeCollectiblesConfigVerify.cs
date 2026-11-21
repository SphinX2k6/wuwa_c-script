using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDD RID: 27613
	public static class IDeliverItemProbeCollectiblesConfigVerify
	{
		// Token: 0x0602F879 RID: 194681 RVA: 0x0067ADE8 File Offset: 0x00678FE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDeliverItemProbeCollectiblesConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDeliverItemProbeCollectiblesConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IHandInItemViewStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B2 RID: 34226
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495B RID: 84315
			public static VerifyTableAction <0>__Verify;
		}
	}
}
