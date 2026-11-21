using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FCF RID: 32719
	public static class TSlideRailEndVerify
	{
		// Token: 0x0603AEA4 RID: 241316 RVA: 0x007EA130 File Offset: 0x007E8330
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerSlideRailEndVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAiFollowerSlideRailEndVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
