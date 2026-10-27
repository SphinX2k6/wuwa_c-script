using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200473B RID: 18235
	public static class IFlowTemplateConfigVerify
	{
		// Token: 0x0601C0B6 RID: 114870 RVA: 0x003F94D5 File Offset: 0x003F76D5
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

		// Token: 0x020079E3 RID: 31203
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401338B RID: 78731
			public static VerifyTableAction <0>__Verify;
		}
	}
}
