using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067F2 RID: 26610
	public static class IAkEventMapType_UnionVerify
	{
		// Token: 0x0602D74C RID: 186188 RVA: 0x006395EC File Offset: 0x006377EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayMapMusicVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAkEventMapTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
