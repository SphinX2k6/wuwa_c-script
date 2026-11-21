using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200461B RID: 17947
	public static class ITetrisPlayModeBase_UnionVerify
	{
		// Token: 0x0601A3FD RID: 107517 RVA: 0x003BCC18 File Offset: 0x003BAE18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITetrisPlayModeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITetrisPlayModeNormalVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITetrisPlayModeEndlessVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITetrisPlayModeMainLineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
