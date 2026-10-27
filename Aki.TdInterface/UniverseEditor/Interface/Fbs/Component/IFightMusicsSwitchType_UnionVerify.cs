using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524B RID: 21067
	public static class IFightMusicsSwitchType_UnionVerify
	{
		// Token: 0x0602244E RID: 140366 RVA: 0x004C0AD8 File Offset: 0x004BECD8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFightMusicsSwitchByTagListVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFightMusicsSwitchTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
