using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B8 RID: 22968
	public static class IStateRepPerfItemVerify
	{
		// Token: 0x06026EA6 RID: 159398 RVA: 0x0055AAE8 File Offset: 0x00558CE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IStateRepPerfItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateRepPerfItemVerify.<>O.<0>__Verify = new VerifyUnionAction(TStateRepPerfVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C3D RID: 31805
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401372B RID: 79659
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
