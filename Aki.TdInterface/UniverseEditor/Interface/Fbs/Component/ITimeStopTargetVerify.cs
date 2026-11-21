using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C9 RID: 24777
	public static class ITimeStopTargetVerify
	{
		// Token: 0x06029ECD RID: 171725 RVA: 0x005B8CA0 File Offset: 0x005B6EA0
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

		// Token: 0x020084D7 RID: 34007
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014821 RID: 84001
			public static VerifyTableAction <0>__Verify;
		}
	}
}
