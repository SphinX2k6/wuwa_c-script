using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004240 RID: 16960
	public static class IEnterDungeon_UnionVerify
	{
		// Token: 0x06017987 RID: 96647 RVA: 0x0035DAF8 File Offset: 0x0035BCF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEnterDungeonVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEnterDungeonIdConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnterDungeonSubTypeConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
