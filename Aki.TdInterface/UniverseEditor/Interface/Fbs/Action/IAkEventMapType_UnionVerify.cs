using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006187 RID: 24967
	public static class IAkEventMapType_UnionVerify
	{
		// Token: 0x0602B01B RID: 176155 RVA: 0x005EED78 File Offset: 0x005ECF78
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
