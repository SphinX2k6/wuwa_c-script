using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007812 RID: 30738
	public static class TVisualNovelDisplayItemVerify
	{
		// Token: 0x06037BBB RID: 228283 RVA: 0x00788B20 File Offset: 0x00786D20
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelDisplayItemCloseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelDisplayItemImageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelDisplayItemPrefabVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
