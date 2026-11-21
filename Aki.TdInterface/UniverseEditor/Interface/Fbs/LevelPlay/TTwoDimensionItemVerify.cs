using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A8A RID: 19082
	public static class TTwoDimensionItemVerify
	{
		// Token: 0x0601CAF9 RID: 117497 RVA: 0x0040BA4C File Offset: 0x00409C4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDangoBrawlBagVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDangoBrawlItemVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMarbleCommonItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMarbleSpawnPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
