using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC6 RID: 19654
	public static class IEditorConnectionConfigVerify
	{
		// Token: 0x0601E3D4 RID: 123860 RVA: 0x0043CB2D File Offset: 0x0043AD2D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEditorConnectionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEditorConnectionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008258 RID: 33368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401442F RID: 82991
			public static VerifyTableAction <0>__Verify;
		}
	}
}
