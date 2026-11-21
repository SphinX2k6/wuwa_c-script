using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C90 RID: 19600
	public static class IBrushGridLayerVerify
	{
		// Token: 0x0601E0DD RID: 123101 RVA: 0x004366B8 File Offset: 0x004348B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBrushGridLayerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBrushGridLayerVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008252 RID: 33362
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014420 RID: 82976
			public static VerifyTableAction <0>__Verify;
		}
	}
}
