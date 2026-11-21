using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008035 RID: 32821
	public static class TUiStyleOfLevelDVerify
	{
		// Token: 0x0603B0E2 RID: 241890 RVA: 0x007ED950 File Offset: 0x007EBB50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IUiStylePlayPianoOfLevelDVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IUiStyleGiantSubtitleOfLevelDVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
