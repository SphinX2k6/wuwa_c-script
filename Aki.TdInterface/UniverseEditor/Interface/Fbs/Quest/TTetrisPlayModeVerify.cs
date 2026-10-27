using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004325 RID: 17189
	public static class TTetrisPlayModeVerify
	{
		// Token: 0x060197DE RID: 104414 RVA: 0x003A6E1C File Offset: 0x003A501C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITetrisPlayModeEndlessVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITetrisPlayModeMainLineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITetrisPlayModeNormalVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
