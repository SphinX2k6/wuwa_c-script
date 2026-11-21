using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D57 RID: 19799
	public static class TSyncBlockContextVerify
	{
		// Token: 0x0601EB06 RID: 125702 RVA: 0x0044B168 File Offset: 0x00449368
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IQuestSyncBlockContextVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILevelPlaySyncBlockContextVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
