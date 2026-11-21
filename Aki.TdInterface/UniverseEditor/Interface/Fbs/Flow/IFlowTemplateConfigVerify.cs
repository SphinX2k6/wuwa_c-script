using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA3 RID: 19363
	public static class IFlowTemplateConfigVerify
	{
		// Token: 0x0601D88B RID: 120971 RVA: 0x00425771 File Offset: 0x00423971
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowTemplateConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowTemplateConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTemplateDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200822C RID: 33324
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143F2 RID: 82930
			public static VerifyTableAction <0>__Verify;
		}
	}
}
