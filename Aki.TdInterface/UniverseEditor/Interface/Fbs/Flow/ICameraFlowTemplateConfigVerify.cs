using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200472C RID: 18220
	public static class ICameraFlowTemplateConfigVerify
	{
		// Token: 0x0601BFF2 RID: 114674 RVA: 0x003F7A8D File Offset: 0x003F5C8D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraFlowTemplateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraFlowTemplateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraTemplateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079DE RID: 31198
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013385 RID: 78725
			public static VerifyTableAction <0>__Verify;
		}
	}
}
