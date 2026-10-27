using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A5A RID: 23130
	public static class ITemplateMatrixRowVerify
	{
		// Token: 0x060275A7 RID: 161191 RVA: 0x0056A66D File Offset: 0x0056886D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITemplateMatrixRowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITemplateMatrixRowVerify.<>O.<0>__Verify = new VerifyTableAction(ISpawnTemplateEntityConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C58 RID: 31832
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013766 RID: 79718
			public static VerifyTableAction <0>__Verify;
		}
	}
}
