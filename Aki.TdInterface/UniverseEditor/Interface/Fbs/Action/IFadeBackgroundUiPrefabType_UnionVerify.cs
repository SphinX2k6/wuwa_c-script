using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E11 RID: 28177
	public static class IFadeBackgroundUiPrefabType_UnionVerify
	{
		// Token: 0x06030A4E RID: 199246 RVA: 0x0069A5AC File Offset: 0x006987AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFadeBackgroundUiPrefabBlackScreenWhiteTextVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFadeBackgroundUiPrefabTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
