using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D85 RID: 28037
	public static class IPostProcessVolumeCenterPositionVerify
	{
		// Token: 0x0603186F RID: 202863 RVA: 0x006B6A20 File Offset: 0x006B4C20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPostProcessVolumeCenterPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPostProcessVolumeCenterPositionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E03 RID: 32259
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139BE RID: 80318
			public static VerifyTableAction <0>__Verify;
		}
	}
}
