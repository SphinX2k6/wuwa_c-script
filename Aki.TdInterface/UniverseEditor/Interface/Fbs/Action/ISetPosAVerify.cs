using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007829 RID: 30761
	public static class ISetPosAVerify
	{
		// Token: 0x06036196 RID: 221590 RVA: 0x0073F9D5 File Offset: 0x0073DBD5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetPosAVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetPosAVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086E3 RID: 34531
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AF6 RID: 84726
			public static VerifyTableAction <0>__Verify;
		}
	}
}
