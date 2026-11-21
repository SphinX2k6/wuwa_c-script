using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEC RID: 27628
	public static class IDestroyDynamicEntitiesVerify
	{
		// Token: 0x0602F8CC RID: 194764 RVA: 0x0067B55D File Offset: 0x0067975D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDestroyDynamicEntitiesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroyDynamicEntitiesVerify.<>O.<0>__Verify = new VerifyTableAction(IDestroyVisionDisplayVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085B3 RID: 34227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401495C RID: 84316
			public static VerifyTableAction <0>__Verify;
		}
	}
}
