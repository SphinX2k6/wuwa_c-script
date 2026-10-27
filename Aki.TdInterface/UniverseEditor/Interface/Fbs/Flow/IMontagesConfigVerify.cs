using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004744 RID: 18244
	public static class IMontagesConfigVerify
	{
		// Token: 0x0601C138 RID: 115000 RVA: 0x003FA5DD File Offset: 0x003F87DD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontagesConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontagesConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079E5 RID: 31205
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401338E RID: 78734
			public static VerifyTableAction <0>__Verify;
		}
	}
}
