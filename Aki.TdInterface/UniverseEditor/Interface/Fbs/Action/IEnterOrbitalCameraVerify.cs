using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C2 RID: 26306
	public static class IEnterOrbitalCameraVerify
	{
		// Token: 0x0602DBA7 RID: 187303 RVA: 0x00641814 File Offset: 0x0063FA14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnterOrbitalCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnterOrbitalCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IEnterOrbitalCameraControlByMoveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D52 RID: 32082
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138CF RID: 80079
			public static VerifyTableAction <0>__Verify;
		}
	}
}
