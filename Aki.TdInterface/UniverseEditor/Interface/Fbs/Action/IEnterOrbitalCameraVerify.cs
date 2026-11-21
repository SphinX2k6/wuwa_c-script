using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3C RID: 27964
	public static class IEnterOrbitalCameraVerify
	{
		// Token: 0x060303C4 RID: 197572 RVA: 0x0068EAC8 File Offset: 0x0068CCC8
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

		// Token: 0x020085C9 RID: 34249
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401497B RID: 84347
			public static VerifyTableAction <0>__Verify;
		}
	}
}
