using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485E RID: 18526
	public static class IEditorConnectionConfigVerify
	{
		// Token: 0x0601CBCD RID: 117709 RVA: 0x00410081 File Offset: 0x0040E281
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

		// Token: 0x02007A0F RID: 31247
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133C8 RID: 78792
			public static VerifyTableAction <0>__Verify;
		}
	}
}
