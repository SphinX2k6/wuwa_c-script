using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007387 RID: 29575
	public static class IOpenQteConfig_UnionVerify
	{
		// Token: 0x06033A30 RID: 211504 RVA: 0x006F5DC4 File Offset: 0x006F3FC4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOpenQteConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenPanelQteQteVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenLevelQteVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
