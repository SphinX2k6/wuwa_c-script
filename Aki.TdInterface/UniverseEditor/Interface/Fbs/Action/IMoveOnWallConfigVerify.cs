using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007293 RID: 29331
	public static class IMoveOnWallConfigVerify
	{
		// Token: 0x060331CF RID: 209359 RVA: 0x006E5AFD File Offset: 0x006E3CFD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveOnWallConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveOnWallConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008642 RID: 34370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A17 RID: 84503
			public static VerifyTableAction <0>__Verify;
		}
	}
}
