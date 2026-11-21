using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B3 RID: 22451
	public static class IFightMusicsSwitchType_UnionVerify
	{
		// Token: 0x060243E4 RID: 148452 RVA: 0x004FB59C File Offset: 0x004F979C
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
