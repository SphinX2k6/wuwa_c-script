using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C2 RID: 16834
	public static class ITetrisPlayModeBase_UnionVerify
	{
		// Token: 0x06018CA7 RID: 101543 RVA: 0x003917C4 File Offset: 0x0038F9C4
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
