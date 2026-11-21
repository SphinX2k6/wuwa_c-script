using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005465 RID: 21605
	public static class IBuffProducerComponentVerify
	{
		// Token: 0x06021EF4 RID: 138996 RVA: 0x004AD580 File Offset: 0x004AB780
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBuffProducerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBuffProducerComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TAddBuffModeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082EC RID: 33516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144EC RID: 83180
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
