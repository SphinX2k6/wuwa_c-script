using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BF RID: 22463
	public static class IQteCallbackVerify
	{
		// Token: 0x06025B3F RID: 154431 RVA: 0x005332DC File Offset: 0x005314DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQteCallbackVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQteCallbackVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BEF RID: 31727
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B8 RID: 79544
			public static VerifyTableAction <0>__Verify;
		}
	}
}
