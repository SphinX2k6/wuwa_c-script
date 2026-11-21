using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060AB RID: 24747
	public static class ITimeScheduleFixedPositionsVerify
	{
		// Token: 0x06029E01 RID: 171521 RVA: 0x005B76F0 File Offset: 0x005B58F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleFixedPositionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleFixedPositionsVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084D4 RID: 34004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401481C RID: 83996
			public static VerifyTableAction <0>__Verify;
		}
	}
}
