using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005774 RID: 22388
	public static class IPortalRenderConfigVerify
	{
		// Token: 0x0602586C RID: 153708 RVA: 0x0052D50C File Offset: 0x0052B70C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPortalRenderConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPortalRenderConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TPortalViewDistanceConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPortalRenderConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPortalRenderConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 10, 2UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BE1 RID: 31713
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A5 RID: 79525
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040136A6 RID: 79526
			public static VerifyTableAction <1>__Verify;
		}
	}
}
