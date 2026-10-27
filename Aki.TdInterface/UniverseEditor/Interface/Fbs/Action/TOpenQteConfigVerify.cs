using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007742 RID: 30530
	public static class TOpenQteConfigVerify
	{
		// Token: 0x06037789 RID: 227209 RVA: 0x00782588 File Offset: 0x00780788
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOpenPanelQteQteVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOpenLevelQteVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
