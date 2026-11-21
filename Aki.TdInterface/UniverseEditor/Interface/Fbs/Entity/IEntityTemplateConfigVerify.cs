using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C42 RID: 19522
	public static class IEntityTemplateConfigVerify
	{
		// Token: 0x0601DF07 RID: 122631 RVA: 0x00432C69 File Offset: 0x00430E69
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTemplateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTemplateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityTemplateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008249 RID: 33353
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014416 RID: 82966
			public static VerifyTableAction <0>__Verify;
		}
	}
}
