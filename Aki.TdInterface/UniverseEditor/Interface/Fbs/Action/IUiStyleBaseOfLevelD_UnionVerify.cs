using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA6 RID: 31910
	public static class IUiStyleBaseOfLevelD_UnionVerify
	{
		// Token: 0x060398F6 RID: 235766 RVA: 0x007C4970 File Offset: 0x007C2B70
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
