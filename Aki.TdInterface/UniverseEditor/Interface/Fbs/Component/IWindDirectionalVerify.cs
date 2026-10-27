using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B7C RID: 23420
	public static class IWindDirectionalVerify
	{
		// Token: 0x0602817A RID: 164218 RVA: 0x00582E9C File Offset: 0x0058109C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWindDirectionalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWindDirectionalVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWindDirectionalVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWindDirectionalVerify.<>O.<1>__Verify = new VerifyTableAction(IWindDirectionalStateGradeVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C80 RID: 31872
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137A9 RID: 79785
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137AA RID: 79786
			public static VerifyTableAction <1>__Verify;
		}
	}
}
