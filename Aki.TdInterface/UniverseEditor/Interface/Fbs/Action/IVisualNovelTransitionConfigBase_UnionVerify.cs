using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E5 RID: 30181
	public static class IVisualNovelTransitionConfigBase_UnionVerify
	{
		// Token: 0x06036F9D RID: 225181 RVA: 0x00775C98 File Offset: 0x00773E98
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelTransitionConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelTransitionLocationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelTransitionTimeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
