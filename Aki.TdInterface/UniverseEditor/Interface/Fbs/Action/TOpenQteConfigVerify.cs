using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F6B RID: 32619
	public static class TOpenQteConfigVerify
	{
		// Token: 0x0603ACC4 RID: 240836 RVA: 0x007E7518 File Offset: 0x007E5718
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
