using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B0 RID: 29872
	public static class IUiStyleBaseOfLevelD_UnionVerify
	{
		// Token: 0x060364ED RID: 222445 RVA: 0x007618E4 File Offset: 0x0075FAE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUiStyleBaseOfLevelDVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUiStyleGiantSubtitleOfLevelDVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUiStylePlayPianoOfLevelDVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
