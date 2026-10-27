using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006791 RID: 26513
	public static class IFadeBackgroundUiPrefabType_UnionVerify
	{
		// Token: 0x0602E208 RID: 188936 RVA: 0x0064CE68 File Offset: 0x0064B068
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
