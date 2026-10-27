using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004828 RID: 18472
	public static class IBrushGridLayerVerify
	{
		// Token: 0x0601C8E0 RID: 116960 RVA: 0x00409D68 File Offset: 0x00407F68
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

		// Token: 0x02007A09 RID: 31241
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B9 RID: 78777
			public static VerifyTableAction <0>__Verify;
		}
	}
}
