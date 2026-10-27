using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E05 RID: 15877
	public static class IEnterDungeon_UnionVerify
	{
		// Token: 0x0601635A RID: 90970 RVA: 0x00334F00 File Offset: 0x00333100
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
