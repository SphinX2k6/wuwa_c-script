using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Aki.UniverseEditor.Interface.Fbs.Editor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047D7 RID: 18391
	public static class IEntityTemplateVerify
	{
		// Token: 0x0601C6F2 RID: 116466 RVA: 0x00405F24 File Offset: 0x00404124
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(TComponentsDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyField(tablePos, 22, 2UL, 2UL, false))
				{
					short offsetId2 = 24;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IWorldEditorTemplateConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079FF RID: 31231
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133AD RID: 78765
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040133AE RID: 78766
			public static VerifyTableAction <1>__Verify;
		}
	}
}
