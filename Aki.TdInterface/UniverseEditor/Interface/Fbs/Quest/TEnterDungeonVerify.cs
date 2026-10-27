using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D1 RID: 17105
	public static class TEnterDungeonVerify
	{
		// Token: 0x060195FC RID: 103932 RVA: 0x003A3F18 File Offset: 0x003A2118
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnterDungeonSubTypeConditionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEnterDungeonIdConditionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
