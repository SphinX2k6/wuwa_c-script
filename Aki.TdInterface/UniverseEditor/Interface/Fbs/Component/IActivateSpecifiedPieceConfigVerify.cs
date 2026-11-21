using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005360 RID: 21344
	public static class IActivateSpecifiedPieceConfigVerify
	{
		// Token: 0x060213BC RID: 136124 RVA: 0x00496254 File Offset: 0x00494454
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActivateSpecifiedPieceConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActivateSpecifiedPieceConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082C0 RID: 33472
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144AA RID: 83114
			public static VerifyTableAction <0>__Verify;
		}
	}
}
