using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200599A RID: 22938
	public static class IStartRotationConfigVerify
	{
		// Token: 0x06026D93 RID: 159123 RVA: 0x00558B1C File Offset: 0x00556D1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStartRotationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStartRotationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C3A RID: 31802
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013726 RID: 79654
			public static VerifyTableAction <0>__Verify;
		}
	}
}
