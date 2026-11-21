using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D7B RID: 23931
	public static class IPortalRenderConfigVerify
	{
		// Token: 0x06027D8C RID: 163212 RVA: 0x00573698 File Offset: 0x00571898
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

		// Token: 0x0200844F RID: 33871
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014745 RID: 83781
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014746 RID: 83782
			public static VerifyTableAction <1>__Verify;
		}
	}
}
