using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048AF RID: 18607
	public static class ISyncBlockContext_UnionVerify
	{
		// Token: 0x0601D0BF RID: 118975 RVA: 0x0041A11C File Offset: 0x0041831C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISyncBlockContextVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILevelPlaySyncBlockContextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestSyncBlockContextVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
