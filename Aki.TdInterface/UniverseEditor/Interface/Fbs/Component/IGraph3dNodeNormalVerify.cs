using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531D RID: 21277
	public static class IGraph3dNodeNormalVerify
	{
		// Token: 0x06022C2D RID: 142381 RVA: 0x004D0CEC File Offset: 0x004CEEEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dNodeNormalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dNodeNormalVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B45 RID: 31557
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401358D RID: 79245
			public static VerifyTableAction <0>__Verify;
		}
	}
}
