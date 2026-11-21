using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D78 RID: 28024
	public static class IExecAlertSystemActionVerify
	{
		// Token: 0x060305C0 RID: 198080 RVA: 0x00692414 File Offset: 0x00690614
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExecAlertSystemActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExecAlertSystemActionVerify.<>O.<0>__Verify = new VerifyUnionAction(TAlertSystemOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085D0 RID: 34256
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014983 RID: 84355
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
