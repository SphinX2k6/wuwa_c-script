using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004622 RID: 17954
	public static class TTwoDimensionItemVerify
	{
		// Token: 0x0601B324 RID: 111396 RVA: 0x003DF7B0 File Offset: 0x003DD9B0
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
