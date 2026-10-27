using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABC RID: 23228
	public static class ITimeStopTargetVerify
	{
		// Token: 0x06027947 RID: 162119 RVA: 0x005719B8 File Offset: 0x0056FBB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeStopTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeStopTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicEntityMatchVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C67 RID: 31847
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401377C RID: 79740
			public static VerifyTableAction <0>__Verify;
		}
	}
}
