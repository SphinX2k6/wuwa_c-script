using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531A RID: 21274
	public static class IGraph3dNodeBaseVerify
	{
		// Token: 0x06022C17 RID: 142359 RVA: 0x004D0A60 File Offset: 0x004CEC60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraph3dNodeBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraph3dNodeBaseVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B44 RID: 31556
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401358C RID: 79244
			public static VerifyTableAction <0>__Verify;
		}
	}
}
