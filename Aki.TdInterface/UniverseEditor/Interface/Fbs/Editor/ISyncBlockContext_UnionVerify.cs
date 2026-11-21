using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D14 RID: 19732
	public static class ISyncBlockContext_UnionVerify
	{
		// Token: 0x0601E8AC RID: 125100 RVA: 0x004468B8 File Offset: 0x00444AB8
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
