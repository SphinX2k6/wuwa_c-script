using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E55 RID: 20053
	public static class IActorAttachTargetVerify
	{
		// Token: 0x0601F7B1 RID: 128945 RVA: 0x00462B30 File Offset: 0x00460D30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActorAttachTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActorAttachTargetVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A70 RID: 31344
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401343D RID: 78909
			public static VerifyTableAction <0>__Verify;
		}
	}
}
