using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004411 RID: 17425
	public static class ILevelsConfigVerify
	{
		// Token: 0x06019F31 RID: 106289 RVA: 0x003B6141 File Offset: 0x003B4341
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelsConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelsConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007995 RID: 31125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013318 RID: 78616
			public static VerifyTableAction <0>__Verify;
		}
	}
}
