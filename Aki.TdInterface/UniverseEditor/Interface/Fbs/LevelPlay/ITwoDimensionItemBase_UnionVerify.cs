using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E0 RID: 17888
	public static class ITwoDimensionItemBase_UnionVerify
	{
		// Token: 0x0601B140 RID: 110912 RVA: 0x003DBCB8 File Offset: 0x003D9EB8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITwoDimensionItemBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMarbleItemLevelBaseVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMarbleCommonItemVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMarbleSpawnPointVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IDangoBrawlObjectBaseVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IDangoBrawlBagVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IDangoBrawlItemVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
