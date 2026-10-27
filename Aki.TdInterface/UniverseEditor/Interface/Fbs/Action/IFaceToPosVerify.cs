using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675B RID: 26459
	public static class IFaceToPosVerify
	{
		// Token: 0x0602E072 RID: 188530 RVA: 0x0064A2FD File Offset: 0x006484FD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFaceToPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFaceToPosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D61 RID: 32097
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138E0 RID: 80096
			public static VerifyTableAction <0>__Verify;
		}
	}
}
