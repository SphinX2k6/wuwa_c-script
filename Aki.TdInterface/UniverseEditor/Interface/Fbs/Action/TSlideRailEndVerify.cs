using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007797 RID: 30615
	public static class TSlideRailEndVerify
	{
		// Token: 0x06037929 RID: 227625 RVA: 0x00784C30 File Offset: 0x00782E30
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
