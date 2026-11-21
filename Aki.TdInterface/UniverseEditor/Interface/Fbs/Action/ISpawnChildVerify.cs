using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200793A RID: 31034
	public static class ISpawnChildVerify
	{
		// Token: 0x06036A6F RID: 223855 RVA: 0x00750110 File Offset: 0x0074E310
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISpawnChildVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnChildVerify.<>O.<0>__Verify = new VerifyTableAction(ITransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086FF RID: 34559
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B1C RID: 84764
			public static VerifyTableAction <0>__Verify;
		}
	}
}
