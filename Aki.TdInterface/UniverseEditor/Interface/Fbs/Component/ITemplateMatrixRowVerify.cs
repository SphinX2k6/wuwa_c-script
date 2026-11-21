using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006067 RID: 24679
	public static class ITemplateMatrixRowVerify
	{
		// Token: 0x06029B1F RID: 170783 RVA: 0x005B1679 File Offset: 0x005AF879
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

		// Token: 0x020084C7 RID: 33991
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401480A RID: 83978
			public static VerifyTableAction <0>__Verify;
		}
	}
}
