using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005568 RID: 21864
	public static class IMonitorComponentVerify
	{
		// Token: 0x060242BE RID: 148158 RVA: 0x004FEF34 File Offset: 0x004FD134
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

		// Token: 0x02007B91 RID: 31633
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401361A RID: 79386
			public static VerifyTableAction <0>__Verify;
		}
	}
}
