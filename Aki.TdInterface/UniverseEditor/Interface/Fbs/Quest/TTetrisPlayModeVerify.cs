using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004787 RID: 18311
	public static class TTetrisPlayModeVerify
	{
		// Token: 0x0601AF6C RID: 110444 RVA: 0x003D2844 File Offset: 0x003D0A44
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
