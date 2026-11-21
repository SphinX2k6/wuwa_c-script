using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDB RID: 28123
	public static class IFaceToPosVerify
	{
		// Token: 0x060308B8 RID: 198840 RVA: 0x00697A41 File Offset: 0x00695C41
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFaceToPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFaceToPosVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085D8 RID: 34264
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498C RID: 84364
			public static VerifyTableAction <0>__Verify;
		}
	}
}
