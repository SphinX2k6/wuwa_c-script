using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC6 RID: 24006
	public static class IQteCallbackVerify
	{
		// Token: 0x0602805F RID: 163935 RVA: 0x00579468 File Offset: 0x00577668
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

		// Token: 0x0200845D RID: 33885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014758 RID: 83800
			public static VerifyTableAction <0>__Verify;
		}
	}
}
