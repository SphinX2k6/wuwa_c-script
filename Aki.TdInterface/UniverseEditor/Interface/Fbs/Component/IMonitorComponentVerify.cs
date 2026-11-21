using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFA RID: 23290
	public static class IMonitorComponentVerify
	{
		// Token: 0x06026463 RID: 156771 RVA: 0x0053E7F8 File Offset: 0x0053C9F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonitorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonitorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConeTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083F3 RID: 33779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146A9 RID: 83625
			public static VerifyTableAction <0>__Verify;
		}
	}
}
