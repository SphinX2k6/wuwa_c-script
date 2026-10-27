using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F7 RID: 30711
	public static class TUiStyleOfLevelDVerify
	{
		// Token: 0x06037B3D RID: 228157 RVA: 0x00787FD8 File Offset: 0x007861D8
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
