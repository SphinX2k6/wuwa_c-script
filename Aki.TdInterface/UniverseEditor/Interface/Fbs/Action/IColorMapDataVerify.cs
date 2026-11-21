using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC1 RID: 27329
	public static class IColorMapDataVerify
	{
		// Token: 0x0602EE91 RID: 192145 RVA: 0x00663F40 File Offset: 0x00662140
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IColorMapDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IColorMapDataVerify.<>O.<0>__Verify = new VerifyTableAction(IColorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085A0 RID: 34208
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014944 RID: 84292
			public static VerifyTableAction <0>__Verify;
		}
	}
}
