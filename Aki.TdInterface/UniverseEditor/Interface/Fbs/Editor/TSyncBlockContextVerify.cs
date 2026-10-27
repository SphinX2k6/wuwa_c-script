using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048F2 RID: 18674
	public static class TSyncBlockContextVerify
	{
		// Token: 0x0601D319 RID: 119577 RVA: 0x0041E9CC File Offset: 0x0041CBCC
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
